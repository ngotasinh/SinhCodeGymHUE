#pragma checksum "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNETDapper\ASPNETDapper\Views\GroupMeeting\DeleteMeeting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8ba37216e0dc966a27b94f1b37cef7ddb9e0efd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GroupMeeting_DeleteMeeting), @"mvc.1.0.view", @"/Views/GroupMeeting/DeleteMeeting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GroupMeeting/DeleteMeeting.cshtml", typeof(AspNetCore.Views_GroupMeeting_DeleteMeeting))]
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
#line 1 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNETDapper\ASPNETDapper\Views\_ViewImports.cshtml"
using ASPNETDapper;

#line default
#line hidden
#line 2 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNETDapper\ASPNETDapper\Views\_ViewImports.cshtml"
using ASPNETDapper.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8ba37216e0dc966a27b94f1b37cef7ddb9e0efd", @"/Views/GroupMeeting/DeleteMeeting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d18681a247c504ed69766b1ab9f2e84388dfd8c7", @"/Views/_ViewImports.cshtml")]
    public class Views_GroupMeeting_DeleteMeeting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPNETDapper.Models.GroupMeeting>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteMeeting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNETDapper\ASPNETDapper\Views\GroupMeeting\DeleteMeeting.cshtml"
  
    ViewData["Title"] = "DeleteMeeting";

#line default
#line hidden
            BeginContext(92, 189, true);
            WriteLiteral("\r\n<h1>DeleteMeeting</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>GroupMeeting</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(282, 38, false);
#line 15 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNETDapper\ASPNETDapper\Views\GroupMeeting\DeleteMeeting.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(320, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(384, 34, false);
#line 18 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNETDapper\ASPNETDapper\Views\GroupMeeting\DeleteMeeting.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(418, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(481, 47, false);
#line 21 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNETDapper\ASPNETDapper\Views\GroupMeeting\DeleteMeeting.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(528, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(592, 43, false);
#line 24 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNETDapper\ASPNETDapper\Views\GroupMeeting\DeleteMeeting.cshtml"
       Write(Html.DisplayFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(635, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(698, 56, false);
#line 27 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNETDapper\ASPNETDapper\Views\GroupMeeting\DeleteMeeting.cshtml"
       Write(Html.DisplayNameFor(model => model.GroupMeetingLeadName));

#line default
#line hidden
            EndContext();
            BeginContext(754, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(818, 52, false);
#line 30 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNETDapper\ASPNETDapper\Views\GroupMeeting\DeleteMeeting.cshtml"
       Write(Html.DisplayFor(model => model.GroupMeetingLeadName));

#line default
#line hidden
            EndContext();
            BeginContext(870, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(933, 48, false);
#line 33 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNETDapper\ASPNETDapper\Views\GroupMeeting\DeleteMeeting.cshtml"
       Write(Html.DisplayNameFor(model => model.TeamLeadName));

#line default
#line hidden
            EndContext();
            BeginContext(981, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1045, 44, false);
#line 36 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNETDapper\ASPNETDapper\Views\GroupMeeting\DeleteMeeting.cshtml"
       Write(Html.DisplayFor(model => model.TeamLeadName));

#line default
#line hidden
            EndContext();
            BeginContext(1089, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1152, 47, false);
#line 39 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNETDapper\ASPNETDapper\Views\GroupMeeting\DeleteMeeting.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1263, 43, false);
#line 42 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNETDapper\ASPNETDapper\Views\GroupMeeting\DeleteMeeting.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1369, 52, false);
#line 45 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNETDapper\ASPNETDapper\Views\GroupMeeting\DeleteMeeting.cshtml"
       Write(Html.DisplayNameFor(model => model.GroupMeetingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1421, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1485, 48, false);
#line 48 "D:\SinhCodeGymHUE\module2\ASP.NET\ASPNETDapper\ASPNETDapper\Views\GroupMeeting\DeleteMeeting.cshtml"
       Write(Html.DisplayFor(model => model.GroupMeetingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1533, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1571, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8ba37216e0dc966a27b94f1b37cef7ddb9e0efd10061", async() => {
                BeginContext(1604, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1687, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8ba37216e0dc966a27b94f1b37cef7ddb9e0efd10535", async() => {
                    BeginContext(1709, 12, true);
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
                BeginContext(1725, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1738, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPNETDapper.Models.GroupMeeting> Html { get; private set; }
    }
}
#pragma warning restore 1591
