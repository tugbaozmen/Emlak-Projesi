#pragma checksum "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5684024dac80159a29d96aeb6afc760c1ccdc125"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_CreateUser), @"mvc.1.0.view", @"/Views/User/CreateUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5684024dac80159a29d96aeb6afc760c1ccdc125", @"/Views/User/CreateUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"652f9e43af41c12b1c7dff8064fc10687e623760", @"/Views/_ViewImports.cshtml")]
    public class Views_User_CreateUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EstateProject.PL.Models.UserRoleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
  
    ViewBag.Title = "CreateUser";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 16 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
 using (Html.BeginForm("CreateUser", "User", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\" style=\"margin-left:10px;\">\r\n\r\n    <hr />\r\n    ");
#nullable restore
#line 23 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 27 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
   Write(Html.LabelFor(model => model.FirstName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-5\">\r\n            ");
#nullable restore
#line 29 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
       Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 30 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 34 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
   Write(Html.LabelFor(model => model.LastName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-5\">\r\n            ");
#nullable restore
#line 36 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
       Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 37 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 41 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
   Write(Html.LabelFor(model => model.RoleName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-5\">\r\n            ");
#nullable restore
#line 43 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
       Write(Html.DropDownListFor(a => a.RoleId, (IEnumerable<SelectListItem>)ViewBag.Role, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 44 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.RoleId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 49 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
   Write(Html.LabelFor(model => model.Phone, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-5\">\r\n            ");
#nullable restore
#line 51 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
       Write(Html.EditorFor(model => model.Phone, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 52 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.Phone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 57 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
   Write(Html.LabelFor(model => model.HomePhone, htmlAttributes: new { @class = "control-label col-md-2", @type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-5\">\r\n            ");
#nullable restore
#line 59 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
       Write(Html.EditorFor(model => model.HomePhone, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 60 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.HomePhone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 64 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
   Write(Html.LabelFor(model => model.UserName, htmlAttributes: new { @class = "control-label col-md-2", @type = "email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-5\">\r\n            ");
#nullable restore
#line 66 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
       Write(Html.EditorFor(model => model.UserName, new { htmlAttributes = new { @class = "form-control", @placeholder = "E-Posta" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 67 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 71 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
   Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-5\">\r\n            ");
#nullable restore
#line 73 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
       Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control", @type = "password" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 74 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
       Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Oluştur\" class=\"btn btn-primary\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 83 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"margin-left:10px;\">\r\n    ");
#nullable restore
#line 86 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
Write(Html.ActionLink("<< Listeye Geri Dön >>", "ListUser"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 89 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
 if (ViewBag.IsSuccess != null)
{
    if (ViewBag.IsSuccess)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"alert-info\">Kayıt başarılı</span>\r\n        <br />\r\n");
#nullable restore
#line 95 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"alert-danger\">Kayıt işlemi başarısız</span>\r\n");
#nullable restore
#line 99 "C:\Users\tugba\source\repos\EstateProject\EstateProject.PL\Views\User\CreateUser.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EstateProject.PL.Models.UserRoleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
