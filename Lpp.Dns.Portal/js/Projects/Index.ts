﻿/// <reference path="../_rootlayout.ts" />

module Projects.Index {
    var vm: ViewModel;

    export class ViewModel extends Global.PageViewModel {
        public ds: kendo.data.DataSource;

        constructor(gProjectsSetting: string, bindingControl: JQuery, screenPermissions: any[]) {
            super(bindingControl, screenPermissions);
            var self = this;

            this.ds = new kendo.data.DataSource({
                type: "webapi",
                serverPaging: true,
                serverSorting: true,
                serverFiltering: true,
                transport: {
                    read: {
                        url: Global.Helpers.GetServiceUrl("/projects/list?$select=ID,Name,Group, GroupID,Description"),
                    }
                },
                schema: {
                    model: kendo.data.Model.define(Dns.Interfaces.KendoModelDataMartDTO)
                },
                sort: { field: "Name", dir: "asc" },

            });
            Global.Helpers.SetDataSourceFromSettings(this.ds, gProjectsSetting);  
        }

        public btnNewProject_Click() {
            window.location.href = "/projects/details";
        }

        public ProjectsGrid(): kendo.ui.Grid {
            return $("#gProjects").data("kendoGrid");
        }

        public Save() {
            
        }
    }

    export function NameAnchor(dataItem: Dns.Interfaces.IProjectDTO): string {
        return "<a href=\"/projects/details?ID=" + dataItem.ID + "\">" + dataItem.Name + "</a>";
    }

    export function GroupAnchor(dataItem: Dns.Interfaces.IProjectDTO): string {
        return "<a href=\"/groups/details?ID=" + dataItem.GroupID + "\">" + dataItem.Group + "</a>";
    }

    function init() {
        $.when<any>(Users.GetSetting("Projects.Index.gProjects.User:" + User.ID),
        Dns.WebApi.Users.GetGlobalPermission(Permissions.Group.CreateProject)).done((gProjectsSetting, canAdd) => {
            $(() => {
                var bindingControl = $("#Content");
                vm = new ViewModel(gProjectsSetting, bindingControl, canAdd[0] ? [Permissions.Group.CreateProject] : []);
                ko.applyBindings(vm, bindingControl[0]);
                Global.Helpers.SetGridFromSettings(vm.ProjectsGrid(), gProjectsSetting);
                vm.ProjectsGrid().bind("dataBound", function (e) {
                  Users.SetSetting("Projects.Index.gProjects.User:" + User.ID, Global.Helpers.GetGridSettings(vm.ProjectsGrid()));
                });
            });
        });
    }

    init();
}