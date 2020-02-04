﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lpp.Dns.General.Metadata.Views
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Lpp;
    using Lpp.Dns.General.CriteriaGroup;
    using Lpp.Dns.General.CriteriaGroup.Models;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    using Lpp.Utilities.Legacy;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DisplayRegSearch.cshtml")]
    public partial class DisplayRegSearch : System.Web.Mvc.WebViewPage<Lpp.Dns.General.Metadata.Models.MetadataRegSearchModel>
    {
        public DisplayRegSearch()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"ui-groupbox\"");

WriteLiteral(" id=\"RegSearch\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui-groupbox-header\"");

WriteLiteral("><span>Search Criteria</span></div>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"hData\"");

WriteLiteral(" name=\"Data\"");

WriteLiteral(" /> <!--The entire model is stored in here as json-->\r\n    <fieldset>\r\n        <l" +
"egend>Registry Items</legend>\r\n        <ol>\r\n            <li><span>Classificatio" +
"n</span></li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkClassificationDiseaseDisorderCondition\"");

WriteLiteral(" data-bind=\"visible: ClassificationDiseaseDisorderCondition()\"");

WriteLiteral(">Disease/Disorder/Condition</label>\r\n            </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkClassificationRareDiseaseDisorderCondition\"");

WriteLiteral(" data-bind=\"visible: ClassificationRareDiseaseDisorderCondition()\"");

WriteLiteral(">Rare Disease/Disorder/Condition</label>\r\n            </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkClassificationPregnancy\"");

WriteLiteral(" data-bind=\"visible: ClassificationPregnancy()\"");

WriteLiteral(">Pregnancy</label>\r\n            </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkClassificationPregnancy\"");

WriteLiteral(" data-bind=\"visible: ClassificationPregnancy()\"");

WriteLiteral("> Pregnancy</label>\r\n            </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkClassificationProductBiologic\"");

WriteLiteral(" data-bind=\"visible: ClassificationProductBiologic()\"");

WriteLiteral(">\r\n                    Product,Biologic\r\n                </label>\r\n            </" +
"li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkClassificationProductDevice\"");

WriteLiteral(" data-bind=\"visible: ClassificationProductDevice()\"");

WriteLiteral(">\r\n                    Product,Device\r\n                </label>\r\n            </li" +
">\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkClassificationProductDrug\"");

WriteLiteral(" data-bind=\"visible: ClassificationProductDrug()\"");

WriteLiteral(">\r\n                    Product,Drug\r\n                </label>\r\n            </li>\r" +
"\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkClassificationServiceEncounter\"");

WriteLiteral(" data-bind=\"visible: ClassificationServiceEncounter()\"");

WriteLiteral(">\r\n                    Service,Encounter\r\n                </label>\r\n            <" +
"/li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkClassificationServiceHospitalization\"");

WriteLiteral(" data-bind=\"visible: ClassificationServiceHospitalization()\"");

WriteLiteral(">\r\n                    Service,Hospitalization\r\n                </label>\r\n       " +
"     </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkClassificationServiceProcedure\"");

WriteLiteral(" data-bind=\"visible: ClassificationServiceProcedure()\"");

WriteLiteral(">\r\n                    Service,Procedure\r\n                </label>\r\n            <" +
"/li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkClassificationTransplant\"");

WriteLiteral(" data-bind=\"visible: ClassificationTransplant()\"");

WriteLiteral(">\r\n                    Transplant\r\n                </label>\r\n            </li>\r\n " +
"           <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkClassificationTumor\"");

WriteLiteral(" data-bind=\"visible: ClassificationTumor()\"");

WriteLiteral(">\r\n                    Tumor\r\n                </label>\r\n            </li>\r\n      " +
"      <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkClassificationVaccine\"");

WriteLiteral(" data-bind=\"visible: ClassificationVaccine()\"");

WriteLiteral(">\r\n                    Vaccine\r\n                </label>\r\n            </li>\r\n    " +
"    </ol>\r\n        <br");

WriteLiteral(" style=\"clear:both\"");

WriteLiteral(" />\r\n        <ol>\r\n            <li><span>Purpose</span></li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkPurposeClinicalPracticeAssessment\"");

WriteLiteral(" data-bind=\"visible: PurposeClinicalPracticeAssessment()\"");

WriteLiteral(">\r\n                    Clinical Practice Assessment\r\n                </label>\r\n  " +
"          </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkPurposeEffectiveness\"");

WriteLiteral(" data-bind=\"visible: PurposeEffectiveness()\"");

WriteLiteral(">\r\n                    Effectiveness\r\n                </label>\r\n            </li>" +
"\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkPurposeNaturalHistoryofDisease\"");

WriteLiteral(" data-bind=\"visible: PurposeNaturalHistoryofDisease()\"");

WriteLiteral(">\r\n                    Natural History of Disease\r\n                </label>\r\n    " +
"        </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkPurposePaymentCertification\"");

WriteLiteral(" data-bind=\"visible: PurposePaymentCertification()\"");

WriteLiteral(">\r\n                    Payment/Certification\r\n                </label>\r\n         " +
"   </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkPurposePostMarketingCommitment\"");

WriteLiteral(" data-bind=\"visible: PurposePostMarketingCommitment()\"");

WriteLiteral(">\r\n                    Post Marketing Commitment\r\n                </label>\r\n     " +
"       </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkPurposePublicHealthSurveillance\"");

WriteLiteral(" data-bind=\"visible: PurposePublicHealthSurveillance()\"");

WriteLiteral(">\r\n                    Public Health Surveillance\r\n                </label>\r\n    " +
"        </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkPurposeQualityImprovement\"");

WriteLiteral(" data-bind=\"visible: PurposeQualityImprovement()\"");

WriteLiteral(">\r\n                    Quality Improvement\r\n                </label>\r\n           " +
" </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkPurposeSafetyOrHarm\"");

WriteLiteral(" data-bind=\"visible: PurposeSafetyOrHarm()\"");

WriteLiteral(">\r\n                    Safety Or Harm\r\n                </label>\r\n            </li" +
">\r\n        </ol>\r\n        <br");

WriteLiteral(" style=\"clear:both\"");

WriteLiteral(" />\r\n        <ol>\r\n            <li><span>Condition of Interest</span></li>\r\n     " +
"       <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestBacterialandFungalDiseases\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestBacterialandFungalDiseases()\"");

WriteLiteral(">\r\n                    Bacterial and Fungal Diseases\r\n                </label>\r\n " +
"           </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestBehaviorsandMentalDisorders\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestBehaviorsandMentalDisorders()\"");

WriteLiteral(">\r\n                    Behaviors and Mental Disorders\r\n                </label>\r\n" +
"            </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestBloodandLymphConditions\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestBloodandLymphConditions()\"");

WriteLiteral(">\r\n                    Blood and Lymph Conditions\r\n                </label>\r\n    " +
"        </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestCancersAndOtherNeoplasms\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestCancersAndOtherNeoplasms()\"");

WriteLiteral(">\r\n                    Cancers And Other Neoplasms\r\n                </label>\r\n   " +
"         </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestDigestiveSystemDiseases\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestDigestiveSystemDiseases()\"");

WriteLiteral(">\r\n                    Digestive System Diseases\r\n                </label>\r\n     " +
"       </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestDiseasesOrAbnormalitiesAtOrBeforeBirth\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestDiseasesOrAbnormalitiesAtOrBeforeBirth()\"" +
"");

WriteLiteral(">\r\n                    Diseases Or Abnormalities At Or Before Birth\r\n            " +
"    </label>\r\n            </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestearNoseAndThroatDiseases\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestearNoseAndThroatDiseases()\"");

WriteLiteral(">\r\n                    Ear, Nose, And Throat Diseases\r\n                </label>\r\n" +
"            </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestEyeDiseases\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestGlandAndHormoneRelatedDiseases()\"");

WriteLiteral(">\r\n                    Gland And Hormone Related Diseases\r\n                </labe" +
"l>\r\n            </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestHeartAndBloodDiseases\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestHeartAndBloodDiseases()\"");

WriteLiteral(">\r\n                    Heart And Blood Diseases\r\n                </label>\r\n      " +
"      </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestImmuneSystemDiseases\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestImmuneSystemDiseases()\"");

WriteLiteral(">\r\n                    Immune System Diseases\r\n                </label>\r\n        " +
"    </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestMouthAndToothDiseases\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestMouthAndToothDiseases()\"");

WriteLiteral(">\r\n                    Mouth And Tooth Diseases\r\n                </label>\r\n      " +
"      </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestMuscleBoneCartilageDiseases\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestMuscleBoneCartilageDiseases()\"");

WriteLiteral(">\r\n                    Muscle, Bone, and Cartilage Diseases\r\n                </la" +
"bel>\r\n            </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestOccupationalDiseases\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestOccupationalDiseases()\"");

WriteLiteral(">\r\n                    Occupational Diseases\r\n                </label>\r\n         " +
"   </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestParasiticalDiseases\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestParasiticalDiseases()\"");

WriteLiteral(">\r\n                    Parasitical Diseases\r\n                </label>\r\n          " +
"  </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestRespiratoryTractDiseases\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestRespiratoryTractDiseases()\"");

WriteLiteral(">\r\n                    Respiratory Tract Diseases\r\n                </label>\r\n    " +
"        </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestSkinAndConnectiveTissueDiseases\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestSkinAndConnectiveTissueDiseases()\"");

WriteLiteral(">\r\n                    Skin And Connective Tissue Diseases\r\n                </lab" +
"el>\r\n            </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestSubstanceRelatedDisorders\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestSubstanceRelatedDisorders()\"");

WriteLiteral(">\r\n                    Substance Related Disorders\r\n                </label>\r\n   " +
"         </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestSymptomsAndGeneralPathology\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestSymptomsAndGeneralPathology()\"");

WriteLiteral(">\r\n                    Symptoms And General Pathology\r\n                </label>\r\n" +
"            </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestUrinaryTractSexualOrgansAndPregnancyConditions\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestUrinaryTractSexualOrgansAndPregnancyCondi" +
"tions()\"");

WriteLiteral(">\r\n                    Urinary Tract, SexualOrgans, And Pregnancy Conditions\r\n   " +
"             </label>\r\n            </li>\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestViralDiseases\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestViralDiseases()\"");

WriteLiteral(">\r\n                    Viral Diseases\r\n                </label>\r\n            </li" +
">\r\n            <li");

WriteLiteral(" class=\"col3\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" id=\"chkConditionOfInterestWoundsAndInjuries\"");

WriteLiteral(" data-bind=\"visible: ConditionOfInterestWoundsAndInjuries()\"");

WriteLiteral(">\r\n                    Wounds And Injuries\r\n                </label>\r\n           " +
" </li>\r\n        </ol>\r\n    </fieldset>\r\n    </div>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 11035), Tuple.Create("\"", 11077)
            
            #line 222 "..\..\Views\DisplayRegSearch.cshtml"
, Tuple.Create(Tuple.Create("", 11041), Tuple.Create<System.Object, System.Int32>(this.Resource("CreateRegSearch.js")
            
            #line default
            #line hidden
, 11041), false)
);

WriteLiteral("></script>\r\n    <script>\r\n        //Load the data here from the json that is seri" +
"alized in from the model.\r\n        //Reuses the code from the edit and just chan" +
"ges the bindings\r\n        var data = JSON.parse(\'");

            
            #line 226 "..\..\Views\DisplayRegSearch.cshtml"
                          Write(Html.Raw(Model.Data ?? "{}"));

            
            #line default
            #line hidden
WriteLiteral("\');\r\n        MetadataQuery.CreateRegistrySearch.init(data, $(\"#hData\"), $(\"#RegSe" +
"arch\"));\r\n    </script>\r\n");

        }
    }
}
#pragma warning restore 1591
