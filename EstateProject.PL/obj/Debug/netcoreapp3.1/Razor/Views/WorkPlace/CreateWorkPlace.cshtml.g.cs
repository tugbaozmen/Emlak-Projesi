#pragma checksum "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2051fa5ebea44129ab0b7ff2447c493d872d50e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkPlace_CreateWorkPlace), @"mvc.1.0.view", @"/Views/WorkPlace/CreateWorkPlace.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\_ViewImports.cshtml"
using EstateProject.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\_ViewImports.cshtml"
using EstateProject.PL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2051fa5ebea44129ab0b7ff2447c493d872d50e0", @"/Views/WorkPlace/CreateWorkPlace.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"652f9e43af41c12b1c7dff8064fc10687e623760", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkPlace_CreateWorkPlace : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EstateProject.Entities.WorkPlace>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
  
    ViewBag.Title = "CreateWorkPlace";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
 using (Html.BeginForm("CreateWorkPlace", "WorkPlace", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\" style=\"margin-left:10px;\">\r\n\r\n        <hr />\r\n        ");
#nullable restore
#line 22 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 25 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
       Write(Html.LabelFor(model => model.BusinessName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-5\">\r\n                ");
#nullable restore
#line 27 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
           Write(Html.EditorFor(model => model.BusinessName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
           Write(Html.ValidationMessageFor(model => model.BusinessName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 32 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
       Write(Html.LabelFor(model => model.FirstName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-5\">\r\n                ");
#nullable restore
#line 34 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
           Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 35 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
           Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 39 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
       Write(Html.LabelFor(model => model.LastName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-5\">\r\n                ");
#nullable restore
#line 41 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
           Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 42 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
           Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 46 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
       Write(Html.LabelFor(model => model.Phone, htmlAttributes: new { @class = "control-label col-md-2", @type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-5\">\r\n                ");
#nullable restore
#line 48 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
           Write(Html.EditorFor(model => model.Phone, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 49 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
           Write(Html.ValidationMessageFor(model => model.Phone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 54 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
       Write(Html.LabelFor(model => model.FaxNumber, htmlAttributes: new { @class = "control-label col-md-2", @type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-5\">\r\n                ");
#nullable restore
#line 56 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
           Write(Html.EditorFor(model => model.FaxNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 57 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
           Write(Html.ValidationMessageFor(model => model.FaxNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 61 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
       Write(Html.LabelFor(model => model.Address, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-5\">\r\n                ");
#nullable restore
#line 63 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
           Write(Html.EditorFor(model => model.Address, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 64 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
           Write(Html.ValidationMessageFor(model => model.Address, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Olu??tur\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 73 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"margin-left:10px;\">\r\n    ");
#nullable restore
#line 76 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
Write(Html.ActionLink("<< Listeye Geri D??n >>", "WorkPlaceList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 79 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
 if (ViewBag.IsSuccess != null)
{
    if (ViewBag.IsSuccess)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"alert-info\">Kay??t ba??ar??l??</span>\r\n        <br />\r\n");
#nullable restore
#line 85 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"alert-danger\">Kay??t i??lemi ba??ar??s??z</span>\r\n");
#nullable restore
#line 89 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\WorkPlace\CreateWorkPlace.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EstateProject.Entities.WorkPlace> Html { get; private set; }
    }
}
#pragma warning restore 1591
