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

namespace Lpp.Dns.HealthCare.Summary.Views.Summary
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
    using Lpp.Dns.HealthCare.Summary;
    using Lpp.Dns.HealthCare.Summary.Models;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    using Lpp.Utilities.Legacy;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Summary/Error.cshtml")]
    public partial class Error : System.Web.Mvc.WebViewPage<Lpp.Dns.HealthCare.SummaryQueryBuilder.Code.Exceptions.InvalidDataSetException>
    {
        public Error()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Summary\Error.cshtml"
   this.Stylesheet( "Medical.css" ); 
            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"Exception\"");

WriteLiteral(">\r\n    <p");

WriteLiteral(" class=\"Exception\"");

WriteLiteral(">");

            
            #line 4 "..\..\Views\Summary\Error.cshtml"
                    Write(Model.Message);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
