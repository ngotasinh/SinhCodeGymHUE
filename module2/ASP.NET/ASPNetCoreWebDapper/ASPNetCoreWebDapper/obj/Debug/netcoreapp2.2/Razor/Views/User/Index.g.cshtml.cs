#pragma checksum "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99e780939f8d61bd92e6feb988c7e5a1ba475b33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99e780939f8d61bd92e6feb988c7e5a1ba475b33", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdd805e8e5787da1392b1a526ec9441fad552c75", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASPNetCoreWebDapper.Models.User.UserView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(105, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(134, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99e780939f8d61bd92e6feb988c7e5a1ba475b333907", async() => {
                BeginContext(157, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(171, 103, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\" border=\"1\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(275, 42, false);
#line 16 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(317, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(373, 44, false);
#line 19 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(417, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(473, 39, false);
#line 22 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(512, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(568, 46, false);
#line 25 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserMobile));

#line default
#line hidden
            EndContext();
            BeginContext(614, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(670, 45, false);
#line 28 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserEmail));

#line default
#line hidden
            EndContext();
            BeginContext(715, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(771, 47, false);
#line 31 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FaceBookUrl));

#line default
#line hidden
            EndContext();
            BeginContext(818, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(874, 47, false);
#line 34 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LinkedInUrl));

#line default
#line hidden
            EndContext();
            BeginContext(921, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(977, 46, false);
#line 37 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TwitterUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1079, 50, false);
#line 40 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PersonalWebUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1129, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1185, 45, false);
#line 43 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(1230, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(1565, 65, true);
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 58 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1662, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1711, 41, false);
#line 61 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(1752, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1808, 43, false);
#line 64 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1851, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1907, 38, false);
#line 67 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(1945, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2001, 45, false);
#line 70 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserMobile));

#line default
#line hidden
            EndContext();
            BeginContext(2046, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2102, 44, false);
#line 73 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2146, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2202, 46, false);
#line 76 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FaceBookUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2248, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2304, 46, false);
#line 79 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LinkedInUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2350, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2406, 45, false);
#line 82 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TwitterUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2451, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2507, 49, false);
#line 85 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PersonalWebUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2556, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2612, 44, false);
#line 88 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(2656, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(2988, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(3023, 57, false);
#line 100 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.UserId }));

#line default
#line hidden
            EndContext();
            BeginContext(3080, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3101, 63, false);
#line 101 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.UserId }));

#line default
#line hidden
            EndContext();
            BeginContext(3164, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3185, 61, false);
#line 102 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.UserId }));

#line default
#line hidden
            EndContext();
            BeginContext(3246, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 105 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNetCoreWebDapper\ASPNetCoreWebDapper\Views\User\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3285, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASPNetCoreWebDapper.Models.User.UserView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
