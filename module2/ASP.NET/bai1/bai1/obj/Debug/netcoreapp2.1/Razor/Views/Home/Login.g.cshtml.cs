#pragma checksum "D:\SinhCodeGymHUE\module2\ASP.NET\bai1\bai1\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18774560fed847aac387ff4bce348aa2a3f02214"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
#line 1 "D:\SinhCodeGymHUE\module2\ASP.NET\bai1\bai1\Views\_ViewImports.cshtml"
using bai1;

#line default
#line hidden
#line 2 "D:\SinhCodeGymHUE\module2\ASP.NET\bai1\bai1\Views\_ViewImports.cshtml"
using bai1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18774560fed847aac387ff4bce348aa2a3f02214", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54ca149602d5efa54ff870604ebd94b07f5bc3f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\SinhCodeGymHUE\module2\ASP.NET\bai1\bai1\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 213, true);
            WriteLiteral("\r\n\r\n    <div class=\"limiter\">\r\n        <div class=\"container-login100\" style=\"background-image: url(\'~/images/img/anh0.jpg\')\">\r\n            <div class=\"wrap-login100 p-l-55 p-r-55 p-t-65 p-b-54\">\r\n                ");
            EndContext();
            BeginContext(303, 2692, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78fe06eaf3ba4301995f397000b13453", async() => {
                BeginContext(345, 2643, true);
                WriteLiteral(@"
                    <span class=""login100-form-title p-b-49"">
                        Login
                    </span>

                    <div class=""wrap-input100 validate-input m-b-23"" data-validate=""Username is reauired"">
                        <span class=""label-input100"">Username</span>
                        <input class=""input100"" type=""text"" name=""username"" placeholder=""Type your username"">
                        <span class=""focus-input100"" data-symbol=""&#xf206;""></span>
                    </div>

                    <div class=""wrap-input100 validate-input"" data-validate=""Password is required"">
                        <span class=""label-input100"">Password</span>
                        <input class=""input100"" type=""password"" name=""pass"" placeholder=""Type your password"">
                        <span class=""focus-input100"" data-symbol=""&#xf190;""></span>
                    </div>

                    <div class=""text-right p-t-8 p-b-31"">
                        <a href=""#"">");
                WriteLiteral(@"
                            Forgot password?
                        </a>
                    </div>

                    <div class=""container-login100-form-btn"">
                        <div class=""wrap-login100-form-btn"">
                            <div class=""login100-form-bgbtn""></div>
                            <button class=""login100-form-btn"">
                                Login
                            </button>
                        </div>
                    </div>

                    <div class=""txt1 text-center p-t-54 p-b-20"">
                        <span>
                            Or Sign Up Using
                        </span>
                    </div>

                    <div class=""flex-c-m"">
                        <a href=""#"" class=""login100-social-item bg1"">
                            <i class=""fa fa-facebook""></i>
                        </a>

                        <a href=""#"" class=""login100-social-item bg2"">
                            <i cla");
                WriteLiteral(@"ss=""fa fa-twitter""></i>
                        </a>

                        <a href=""#"" class=""login100-social-item bg3"">
                            <i class=""fa fa-google""></i>
                        </a>
                    </div>

                    <div class=""flex-col-c p-t-155"">
                        <span class=""txt1 p-b-17"">
                            Or Sign Up Using
                        </span>

                        <a href=""#"" class=""txt2"">
                            Sign Up
                        </a>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2995, 52, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
