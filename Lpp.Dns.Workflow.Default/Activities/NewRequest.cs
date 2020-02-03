﻿using Lpp.Utilities;
using Lpp.Dns.Data;
using Lpp.Utilities.Security;
using Lpp.Workflow.Engine;
using Lpp.Workflow.Engine.Interfaces;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lpp.Dns.DTO.Security;
using Lpp.Utilities.Logging;
using Newtonsoft.Json;
//using Lpp.Dns.DTO.Enums;

namespace Lpp.Dns.Workflow.Default.Activities
{
    public class NewRequest : ActivityBase<Request>
    {
        private Guid SubmitResultID = new Guid("48B20001-BD0B-425D-8D49-A3B5015A2258");
        private Guid ReviewResultID = new Guid("C4FB25F8-8521-427E-8FB1-78A84311BF1C");
        private Guid DeleteResultID = new Guid("61110001-1708-4869-BDCF-A3B600E24AA3");
        private Guid SaveResultID = new Guid("DFF3000B-B076-4D07-8D83-05EDE3636F4D");

        private const string DocumentKind = "Lpp.Dns.Workflow.Default.Activities.Request";
        
        public override Guid ID
        {
            get
            {
                return DefaultWorkflowConfiguration.NewRequestActivityID;
            }

        }

        public override string ActivityName
        {
            get
            {
                return "Draft";
            }
        }

        public override string Uri
        {
            get { return "/requests/details?ID=" + _entity.ID; }
        }

        public override string CustomTaskSubject
        {
            get
            {
                return "Compose Request";
            }
        }

        public override async Task<ValidationResult> Validate(Guid? activityResultID)
        {
            var permissions = await db.GetGrantedWorkflowActivityPermissionsForRequestAsync(_workflow.Identity, _entity);

            //default to save result ID if not specified
            if (!activityResultID.HasValue)
                activityResultID = SaveResultID;

            if (activityResultID.Value == SaveResultID && !permissions.Contains(PermissionIdentifiers.ProjectRequestTypeWorkflowActivities.EditTask))
            {
                return new ValidationResult
                {
                    Success = false,
                    Errors = CommonMessages.RequirePermissionToEditTask
                };
            }
            else if (activityResultID.Value == SubmitResultID && !permissions.Contains(PermissionIdentifiers.ProjectRequestTypeWorkflowActivities.CloseTask))
            {
                return new ValidationResult
                {
                    Success = false,
                    Errors = CommonMessages.RequirePermissionToCloseTask
                };
            }
            else if (activityResultID.Value == DeleteResultID && !permissions.Contains(PermissionIdentifiers.ProjectRequestTypeWorkflowActivities.TerminateWorkflow))
            {
                return new ValidationResult
                {
                    Success = false,
                    Errors = CommonMessages.RequirePermissionToTerminateWorkflow
                };
            }

            string errors;
            if (activityResultID.Value == SubmitResultID)
            {
                errors = await PerformSubmitValidation();
            }
            else
            {
                errors = string.Empty;
            }


            if (errors.Length > 0)
            {
                return new ValidationResult
                {
                    Success = false,
                    Errors = errors.ToString()
                };
            }
            else
            {
                return new ValidationResult
                {
                    Success = true
                };
            }
        }

        public override async Task<CompletionResult> Complete(string data, Guid? activityResultID)
        {
            //default to SaveResultID if resultID not specified
            if(!activityResultID.HasValue)
                activityResultID = SaveResultID;            

            var task = await PmnTask.GetActiveTaskForRequestActivityAsync(_entity.ID, ID, db);

            if (activityResultID.Value == SubmitResultID) //Submit
            {

                var filters = new ExtendedQuery
                {
                    Projects = (a) => a.ProjectID == _entity.ProjectID,
                    ProjectOrganizations = a => a.ProjectID == _entity.ProjectID && a.OrganizationID == _entity.OrganizationID,
                    Organizations = a => a.OrganizationID == _entity.OrganizationID,
                    Users = a => a.UserID == _entity.CreatedByID
                };

                var permissions = await db.HasGrantedPermissions<Request>(_workflow.Identity, _entity, filters, PermissionIdentifiers.Request.SkipSubmissionApproval);
                await db.Entry(_entity).ReloadAsync();

                if (Newtonsoft.Json.JsonConvert.DeserializeObject<Lpp.Dns.DTO.QueryComposer.QueryComposerRequestDTO>(_entity.Query).Where.Criteria.Any(c => c.Terms.Any(t => t.Type.ToString().ToUpper() == "2F60504D-9B2F-4DB1-A961-6390117D3CAC") || c.Criteria.Any(ic => ic.Terms.Any(t => t.Type.ToString().ToUpper() == "2F60504D-9B2F-4DB1-A961-6390117D3CAC"))))
                {
                    await db.LoadCollection(_entity, (r) => r.DataMarts);

                    if (!_entity.DataMarts.Any())
                        throw new Exception("At least one routing needs to be specified when submitting a requests.");

                    //prepare the request documents, save created documents same as legacy
                    IList<Guid> documentRevisionSets = Newtonsoft.Json.JsonConvert.DeserializeObject<IList<Guid>>(data);

                    IEnumerable<Document> documents = await (from d in db.Documents.AsNoTracking()
                                                             join x in (
                                                                 db.Documents.Where(dd => documentRevisionSets.Contains(dd.RevisionSetID.Value))
                                                                 .GroupBy(k => k.RevisionSetID)
                                                                 .Select(k => k.OrderByDescending(d => d.MajorVersion).ThenByDescending(d => d.MinorVersion).ThenByDescending(d => d.BuildVersion).ThenByDescending(d => d.RevisionVersion).Select(y => y.ID).Distinct().FirstOrDefault())
                                                             ) on d.ID equals x
                                                             orderby d.ItemID descending, d.RevisionSetID descending, d.CreatedOn descending
                                                             select d).ToArrayAsync();

                    await db.Entry(_entity).Reference(r => r.Activity).LoadAsync();
                    await db.Entry(_entity).Reference(r => r.RequestType).LoadAsync();
                    string submitterEmail = await db.Users.Where(u => u.ID == _workflow.Identity.ID).Select(u => u.Email).SingleAsync();                    

                    //update the request
                    _entity.SubmittedByID = _workflow.Identity.ID;
                    _entity.SubmittedOn = DateTime.UtcNow;
                    _entity.AdapterPackageVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(this.GetType().Assembly.Location).FileVersion;
                    _entity.RejectedByID = null;
                    _entity.RejectedOn = null;
                    _entity.Private = false;
                    

                    //save the changes to the request now since the trigger for routings will change the status invalidating the object before save
                    await db.SaveChangesAsync();
                    await db.Entry(_entity).ReloadAsync();

                    var originalStatus = _entity.Status;
                    await SetRequestStatus(DTO.Enums.RequestStatuses.Submitted, false);

                    foreach (var dm in _entity.DataMarts.Where(dm => dm.Status == 0 || dm.Status == DTO.Enums.RoutingStatus.AwaitingRequestApproval || dm.Status == DTO.Enums.RoutingStatus.Draft))
                    {
                        dm.Status = DTO.Enums.RoutingStatus.Submitted;

                        var currentResponse = db.Responses.FirstOrDefault(r => r.RequestDataMartID == dm.ID && r.Count == r.RequestDataMart.Responses.Max(rr => rr.Count));
                        if (currentResponse == null)
                        {
                            currentResponse = db.Responses.Add(new Response { RequestDataMartID = dm.ID });
                        }
                        currentResponse.SubmittedByID = _workflow.Identity.ID;
                        currentResponse.SubmittedOn = DateTime.UtcNow;

                        //add the request document associations
                        for (int i = 0; i < documentRevisionSets.Count; i++)
                        {
                            db.RequestDocuments.Add(new RequestDocument { RevisionSetID = documentRevisionSets[i], ResponseID = currentResponse.ID, DocumentType = DTO.Enums.RequestDocumentType.Input });
                        }
                    }

                    await db.SaveChangesAsync();
                    //reload the request since altering the routings triggers a change of the request status in the db by a trigger.
                    await db.Entry(_entity).ReloadAsync();

                    DTO.QueryComposer.QueryComposerRequestDTO qcRequestDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO.QueryComposer.QueryComposerRequestDTO>(_entity.Query);
                    var fileUploadTerm = qcRequestDTO.Where.Criteria.SelectMany(c => c.Terms.Where(t => t.Type == FileUploadTermID)).FirstOrDefault();
                    var termValues = Newtonsoft.Json.JsonConvert.DeserializeObject<FileUploadValues>(fileUploadTerm.Values["Values"].ToString());

                    //update the request.json term value to include system generated documents revisionsetIDs
                    termValues.Documents.Clear();

                    for (int i = 0; i < documentRevisionSets.Count; i++)
                    {
                        termValues.Documents.Add(new FileUploadValues.Document { RevisionSetID = documentRevisionSets[i] });
                    }

                    fileUploadTerm.Values["Values"] = termValues;
                    _entity.Query = Newtonsoft.Json.JsonConvert.SerializeObject(qcRequestDTO);

                    await db.SaveChangesAsync();

                    await NotifyRequestStatusChanged(originalStatus, DTO.Enums.RequestStatuses.Submitted);


                }
                else
                {

                    //var parentDocument = db.Documents.FirstOrDefault(d => d.ItemID == task.ID && d.Kind == DocumentKind && d.ParentDocumentID == null);

                    Document parentDocument = await (from d in db.Documents.AsNoTracking()
                                                     join x in (
                                                         db.Documents.Where(dd => dd.ItemID == task.ID && dd.FileName == "request.json")
                                                         .GroupBy(k => k.RevisionSetID)
                                                         .Select(k => k.OrderByDescending(d => d.MajorVersion).ThenByDescending(d => d.MinorVersion).ThenByDescending(d => d.BuildVersion).ThenByDescending(d => d.RevisionVersion).Select(y => y.ID).Distinct().FirstOrDefault())
                                                     ) on d.ID equals x
                                                     orderby d.ItemID descending, d.RevisionSetID descending, d.CreatedOn descending
                                                     select d).FirstOrDefaultAsync();





                    byte[] documentContent = System.Text.UTF8Encoding.UTF8.GetBytes(_entity.Query ?? string.Empty);
                    var document = new Document
                    {
                        Name = "Request Criteria",
                        MajorVersion = parentDocument == null ? 1 : parentDocument.MajorVersion,
                        MinorVersion = parentDocument == null ? 0 : parentDocument.MinorVersion,
                        RevisionVersion = parentDocument == null ? 0 : parentDocument.RevisionVersion,
                        MimeType = "application/json",
                        Viewable = false,
                        UploadedByID = _workflow.Identity.ID,
                        FileName = "request.json",
                        CreatedOn = DateTime.UtcNow,
                        BuildVersion = parentDocument == null ? 0 : parentDocument.BuildVersion,
                        ParentDocumentID = parentDocument == null ? (Guid?)null : parentDocument.ID,
                        ItemID = task.ID,
                        Length = documentContent.LongLength,
                        Kind = Dns.DTO.Enums.DocumentKind.Request
                    };

                    db.Documents.Add(document);
                    document.RevisionSetID = parentDocument == null ? document.ID : parentDocument.RevisionSetID;
                    await db.SaveChangesAsync();

                    document.SetData(db, documentContent);


                    //await db.SaveChangesAsync();

                    await db.Entry(_entity).ReloadAsync();

                    _entity.SubmittedByID = _workflow.Identity.ID;
                    _entity.SubmittedOn = DateTime.UtcNow;
                    _entity.AdapterPackageVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(this.GetType().Assembly.Location).FileVersion;
                    //Reset reject for resubmit.
                    _entity.RejectedByID = null;
                    _entity.RejectedOn = null;
                    _entity.Private = false;

                    await db.SaveChangesAsync();

                    DTO.Enums.RequestStatuses newRequestStatus = DTO.Enums.RequestStatuses.AwaitingRequestApproval;

                    await db.LoadCollection(_entity, (r) => r.DataMarts);

                    if (permissions.Contains(PermissionIdentifiers.Request.SkipSubmissionApproval))
                    {
                        newRequestStatus = DTO.Enums.RequestStatuses.Submitted;

                        foreach (var dm in _entity.DataMarts)
                        {
                            dm.Status = DTO.Enums.RoutingStatus.Submitted;

                            var currentResponse = db.Responses.FirstOrDefault(r => r.RequestDataMartID == dm.ID && r.Count == r.RequestDataMart.Responses.Max(rr => rr.Count));
                            if (currentResponse == null)
                            {
                                currentResponse = db.Responses.Add(new Response { RequestDataMartID = dm.ID });
                            }
                            currentResponse.SubmittedByID = _workflow.Identity.ID;
                            currentResponse.SubmittedOn = DateTime.UtcNow;
                            db.RequestDocuments.Add(new RequestDocument { RevisionSetID = document.RevisionSetID.Value, ResponseID = currentResponse.ID, DocumentType = DTO.Enums.RequestDocumentType.Input });
                        }
                    }
                    else
                    {
                        foreach (var dm in _entity.DataMarts)
                        {
                            dm.Status = DTO.Enums.RoutingStatus.AwaitingRequestApproval;
                        }
                    }

                    _entity.Status = newRequestStatus;

                    await db.SaveChangesAsync();

                    await db.Entry(_entity).ReloadAsync();
                    await SetRequestStatus(newRequestStatus);


                    await MarkTaskComplete(task);
                }

                return new CompletionResult
                {
                    ResultID = permissions.Contains(PermissionIdentifiers.Request.SkipSubmissionApproval) ? SubmitResultID : ReviewResultID
                };

            }
            else if (activityResultID.Value == SaveResultID) //Save
            {

                if (Newtonsoft.Json.JsonConvert.DeserializeObject<Lpp.Dns.DTO.QueryComposer.QueryComposerRequestDTO>(_entity.Query).Where.Criteria.Any(c => c.Terms.Any(t => t.Type.ToString().ToUpper() == "2F60504D-9B2F-4DB1-A961-6390117D3CAC") || c.Criteria.Any(ic => ic.Terms.Any(t => t.Type.ToString().ToUpper() == "2F60504D-9B2F-4DB1-A961-6390117D3CAC"))))
                {
                    await db.Entry(_entity).ReloadAsync();
                    _entity.Private = false;
                    _entity.SubmittedByID = _workflow.Identity.ID;

                    //Reset reject for resubmit.
                    _entity.RejectedByID = null;
                    _entity.RejectedOn = null;

                    var originalStatus = _entity.Status;
                    await SetRequestStatus(DTO.Enums.RequestStatuses.DraftReview);

                    await NotifyRequestStatusChanged(originalStatus, DTO.Enums.RequestStatuses.DraftReview);

                    await MarkTaskComplete(task);
                }
                else
                {

                    if (_entity.Private)
                    {
                        await db.Entry(_entity).ReloadAsync();

                        _entity.Private = false;

                        await task.LogAsModifiedAsync(_workflow.Identity, db);
                        await db.SaveChangesAsync();
                    }
                }

                return new CompletionResult
                {
                    ResultID = SaveResultID
                };
                
            }
            else if (activityResultID.Value == DeleteResultID) //Delete
            {
                db.Requests.Remove(_entity);
                
                if (task != null)
                {
                    db.Actions.Remove(task);
                }

                await db.SaveChangesAsync();

                return null;
            }
            else
            {
                throw new ArgumentOutOfRangeException(CommonMessages.ActivityResultNotSupported);
            }
        }

        public static readonly Guid FileUploadTermID = new Guid("2F60504D-9B2F-4DB1-A961-6390117D3CAC");
        internal class FileUploadValues
        {
            public IList<Document> Documents { get; set; }

            public class Document
            {
                public Guid RevisionSetID { get; set; }
            }
        }
    }
}
