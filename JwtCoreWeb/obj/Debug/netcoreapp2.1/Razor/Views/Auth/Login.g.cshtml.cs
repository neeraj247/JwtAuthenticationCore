#pragma checksum "C:\Users\neewadhw\source\repos\JWTDemoWeb\JwtCoreWeb\Views\Auth\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ed83fa81406e8d4c37836fdb566e0c57c1c5756"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Login), @"mvc.1.0.view", @"/Views/Auth/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auth/Login.cshtml", typeof(AspNetCore.Views_Auth_Login))]
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
#line 1 "C:\Users\neewadhw\source\repos\JWTDemoWeb\JwtCoreWeb\Views\_ViewImports.cshtml"
using JwtCoreWeb;

#line default
#line hidden
#line 2 "C:\Users\neewadhw\source\repos\JWTDemoWeb\JwtCoreWeb\Views\_ViewImports.cshtml"
using JwtCoreWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ed83fa81406e8d4c37836fdb566e0c57c1c5756", @"/Views/Auth/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e99ccb17d54a86c6dd8a0eb15fefcc1353378dfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JwtCoreWeb.Models.Login>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialDate.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\neewadhw\source\repos\JWTDemoWeb\JwtCoreWeb\Views\Auth\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(59, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(88, 679, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae2c3777fda14b00b5469af93989d085", async() => {
                BeginContext(94, 666, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Login</title>

    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js""></script>
    <script type=""text/javascript"">
        $(function () {
            setInterval(function () { $('#divPart').load('_PartialDate'); }, 1000);
        });
    </script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(767, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(769, 1776, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbe40a28e6724365be933efe2d0616f5", async() => {
                BeginContext(775, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 25 "C:\Users\neewadhw\source\repos\JWTDemoWeb\JwtCoreWeb\Views\Auth\Login.cshtml"
     using (Html.BeginForm("login", "auth"))
    {
        

#line default
#line hidden
                BeginContext(839, 23, false);
#line 27 "C:\Users\neewadhw\source\repos\JWTDemoWeb\JwtCoreWeb\Views\Auth\Login.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(864, 40, true);
                WriteLiteral("        <div id=\"divPart\">\r\n            ");
                EndContext();
                BeginContext(904, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "43e6cdd66f3e4fd98921ab9fbfbb0b7e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(942, 442, true);
                WriteLiteral(@"
        </div>
        <div class=""container  mt-5"" style=""width:40%"">
            <table class=""table rounded table-dark"">
                <thead>
                    <tr>
                        <td colspan=""2"" align=""center"">
                            <h3>Login here</h3>
                        </td>
                    </tr>
                </thead>
                <tr>
                    <td>
                        ");
                EndContext();
                BeginContext(1385, 30, false);
#line 42 "C:\Users\neewadhw\source\repos\JWTDemoWeb\JwtCoreWeb\Views\Auth\Login.cshtml"
                   Write(Html.LabelFor(m => m.Username));

#line default
#line hidden
                EndContext();
                BeginContext(1415, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1495, 120, false);
#line 45 "C:\Users\neewadhw\source\repos\JWTDemoWeb\JwtCoreWeb\Views\Auth\Login.cshtml"
                   Write(Html.TextBoxFor(model => model.Username, htmlAttributes: new { @placeholder = "Enter Username", @autocomplete = "off" }));

#line default
#line hidden
                EndContext();
                BeginContext(1615, 32, true);
                WriteLiteral("\r\n                        <br />");
                EndContext();
                BeginContext(1648, 94, false);
#line 46 "C:\Users\neewadhw\source\repos\JWTDemoWeb\JwtCoreWeb\Views\Auth\Login.cshtml"
                         Write(Html.ValidationMessageFor(e => e.Username, "", htmlAttributes: new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1742, 124, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1867, 38, false);
#line 51 "C:\Users\neewadhw\source\repos\JWTDemoWeb\JwtCoreWeb\Views\Auth\Login.cshtml"
                   Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
                EndContext();
                BeginContext(1905, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1985, 98, false);
#line 54 "C:\Users\neewadhw\source\repos\JWTDemoWeb\JwtCoreWeb\Views\Auth\Login.cshtml"
                   Write(Html.PasswordFor(model => model.Password, htmlAttributes: new { @placeholder = "Enter Password" }));

#line default
#line hidden
                EndContext();
                BeginContext(2083, 32, true);
                WriteLiteral("\r\n                        <br />");
                EndContext();
                BeginContext(2116, 94, false);
#line 55 "C:\Users\neewadhw\source\repos\JWTDemoWeb\JwtCoreWeb\Views\Auth\Login.cshtml"
                         Write(Html.ValidationMessageFor(e => e.Password, "", htmlAttributes: new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(2210, 317, true);
                WriteLiteral(@"
                    </td>
                </tr>
                <tr>
                    <td colspan=""2"" align=""right"" style=""margin-right:5px"">
                        <button class=""btn btn-success mr-3""> Login</button>
                    </td>
                </tr>
            </table>
        </div>
");
                EndContext();
#line 65 "C:\Users\neewadhw\source\repos\JWTDemoWeb\JwtCoreWeb\Views\Auth\Login.cshtml"
    }

#line default
#line hidden
                BeginContext(2534, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2545, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JwtCoreWeb.Models.Login> Html { get; private set; }
    }
}
#pragma warning restore 1591
