#pragma checksum "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "055d326038c3a93506830bc1d3dfe7206f8d50fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Details), @"mvc.1.0.view", @"/Views/User/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Details.cshtml", typeof(AspNetCore.Views_User_Details))]
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
#line 1 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\_ViewImports.cshtml"
using ASPNetCoreWebDapper;

#line default
#line hidden
#line 2 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\_ViewImports.cshtml"
using ASPNetCoreWebDapper.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"055d326038c3a93506830bc1d3dfe7206f8d50fc", @"/Views/User/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdd805e8e5787da1392b1a526ec9441fad552c75", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPNetCoreWebDapper.Models.User.UserView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(94, 131, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>UserView</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(226, 42, false);
#line 14 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(268, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(332, 38, false);
#line 17 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(370, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(433, 44, false);
#line 20 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(477, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(541, 40, false);
#line 23 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(581, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(644, 39, false);
#line 26 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(683, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(747, 35, false);
#line 29 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(782, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(845, 46, false);
#line 32 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserMobile));

#line default
#line hidden
            EndContext();
            BeginContext(891, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(955, 42, false);
#line 35 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserMobile));

#line default
#line hidden
            EndContext();
            BeginContext(997, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1060, 45, false);
#line 38 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1169, 41, false);
#line 41 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1273, 47, false);
#line 44 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FaceBookUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1320, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1384, 43, false);
#line 47 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayFor(model => model.FaceBookUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1427, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1490, 47, false);
#line 50 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LinkedInUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1537, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1601, 43, false);
#line 53 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayFor(model => model.LinkedInUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1644, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1707, 46, false);
#line 56 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TwitterUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1753, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1817, 42, false);
#line 59 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayFor(model => model.TwitterUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1859, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1922, 50, false);
#line 62 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PersonalWebUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1972, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2036, 46, false);
#line 65 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayFor(model => model.PersonalWebUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2082, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2145, 45, false);
#line 68 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(2190, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2254, 41, false);
#line 71 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(2295, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
            BeginContext(2969, 30, true);
            WriteLiteral("    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3000, 58, false);
#line 94 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.UserId }));

#line default
#line hidden
            EndContext();
            BeginContext(3058, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3066, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "055d326038c3a93506830bc1d3dfe7206f8d50fc13402", async() => {
                BeginContext(3088, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3104, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPNetCoreWebDapper.Models.User.UserView> Html { get; private set; }
    }
}
#pragma warning restore 1591
