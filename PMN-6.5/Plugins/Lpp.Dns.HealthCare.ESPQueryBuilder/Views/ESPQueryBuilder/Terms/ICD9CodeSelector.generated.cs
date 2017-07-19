﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lpp.Dns.HealthCare.ESPQueryBuilder.Views.ESPQueryBuilder.Terms
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
    using Lpp.Dns.HealthCare.Controllers;
    using Lpp.Dns.HealthCare.ESPQueryBuilder;
    using Lpp.Dns.HealthCare.ESPQueryBuilder.Models;
    using Lpp.Dns.HealthCare.ESPQueryBuilder.Views;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ESPQueryBuilder/Terms/ICD9CodeSelector.cshtml")]
    public partial class ICD9CodeSelector : System.Web.Mvc.WebViewPage<Lpp.Dns.HealthCare.ESPQueryBuilder.Models.ESPQueryBuilderModel>
    {
        public ICD9CodeSelector()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\ESPQueryBuilder\Terms\ICD9CodeSelector.cshtml"
  
    var id = Html.UniqueId();
    Layout = null;
    var btnID = string.Format("btnSelectCode{0}", id);
    var displaySelectedID = string.Format("displayCodes{0}", id);
    var codesID = string.Format("Codes{0}", id);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"ICD9CodeSelectorTerm Term panel panel-default\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" name=\"TermName\"");

WriteLiteral(" value=");

WriteLiteral(" \"ICD9CodeSelector\" hidden=\"hidden\" style=\"display:none\" />\r\n    <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui-button-remove\"");

WriteLiteral("></div>\r\n        ICD 9 Codes\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"ICD9CodeSelector panel-body\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteAttribute("id", Tuple.Create(" id=\"", 707), Tuple.Create("\"", 718)
            
            #line 19 "..\..\Views\ESPQueryBuilder\Terms\ICD9CodeSelector.cshtml"
, Tuple.Create(Tuple.Create("", 712), Tuple.Create<System.Object, System.Int32>(btnID
            
            #line default
            #line hidden
, 712), false)
);

WriteLiteral(">Select...</button>\r\n        <label");

WriteLiteral(" style=\"margin-left:24px;\"");

WriteLiteral(">Selected Codes:&nbsp;</label>\r\n        <span");

WriteAttribute("id", Tuple.Create(" id=\"", 825), Tuple.Create("\"", 848)
            
            #line 21 "..\..\Views\ESPQueryBuilder\Terms\ICD9CodeSelector.cshtml"
, Tuple.Create(Tuple.Create("", 830), Tuple.Create<System.Object, System.Int32>(displaySelectedID
            
            #line default
            #line hidden
, 830), false)
);

WriteLiteral(">");

            
            #line 21 "..\..\Views\ESPQueryBuilder\Terms\ICD9CodeSelector.cshtml"
                                 Write(Model.Codes);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"Codes\"");

WriteAttribute("id", Tuple.Create(" id=\"", 912), Tuple.Create("\"", 925)
            
            #line 22 "..\..\Views\ESPQueryBuilder\Terms\ICD9CodeSelector.cshtml"
, Tuple.Create(Tuple.Create("", 917), Tuple.Create<System.Object, System.Int32>(codesID
            
            #line default
            #line hidden
, 917), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 926), Tuple.Create("\"", 946)
            
            #line 22 "..\..\Views\ESPQueryBuilder\Terms\ICD9CodeSelector.cshtml"
, Tuple.Create(Tuple.Create("", 934), Tuple.Create<System.Object, System.Int32>(Model.Codes
            
            #line default
            #line hidden
, 934), false)
);

WriteLiteral(" />\r\n\r\n    <script>\r\n    $(function () {\r\n        $(\'#");

            
            #line 26 "..\..\Views\ESPQueryBuilder\Terms\ICD9CodeSelector.cshtml"
       Write(btnID);

            
            #line default
            #line hidden
WriteLiteral("\').click(function () {\r\n            var split = ($(\'#");

            
            #line 27 "..\..\Views\ESPQueryBuilder\Terms\ICD9CodeSelector.cshtml"
                        Write(codesID);

            
            #line default
            #line hidden
WriteLiteral(@"').val() || '').split(',');
            Global.Helpers.ShowDialog('Select one or more code(s)', ""/Dialogs/CodeSelector"", [""Close""], 960, 620, {
                ListID: Dns.Enums.Lists.SPANDiagnosis,
                Codes: split
            }).done(function (results) {
                if (!results)
                    return;

                var selectedCodes = results.map(function(i){ return i.Code; });
                $('#");

            
            #line 36 "..\..\Views\ESPQueryBuilder\Terms\ICD9CodeSelector.cshtml"
               Write(codesID);

            
            #line default
            #line hidden
WriteLiteral("\').val(selectedCodes);\r\n                $(\'#");

            
            #line 37 "..\..\Views\ESPQueryBuilder\Terms\ICD9CodeSelector.cshtml"
               Write(displaySelectedID);

            
            #line default
            #line hidden
WriteLiteral("\').text(selectedCodes);\r\n                $(\"form\").formChanged(true);\r\n          " +
"  });\r\n        });\r\n    });\r\n   </script>\r\n    </div>\r\n</div> ");

        }
    }
}
#pragma warning restore 1591
