#pragma checksum "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Home\ClienteLogado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d55c4beb3b7bb41de56c825d066c92b4c1b2c1c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ClienteLogado), @"mvc.1.0.view", @"/Views/Home/ClienteLogado.cshtml")]
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
#line 1 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\_ViewImports.cshtml"
using BancoCunha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\_ViewImports.cshtml"
using BancoCunha.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d55c4beb3b7bb41de56c825d066c92b4c1b2c1c3", @"/Views/Home/ClienteLogado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1e4bd568346788f335f50c6788235f3bc523739", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ClienteLogado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BancoCunha.Models.Conta>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/cartao.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/avatarM2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Home\ClienteLogado.cshtml"
  
    ViewData["Title"] = "Banco Cunha - ??rea do Cliente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d55c4beb3b7bb41de56c825d066c92b4c1b2c1c35107", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 13 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Home\ClienteLogado.cshtml"
 foreach (var item in Model)
{



#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"login-dark\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d55c4beb3b7bb41de56c825d066c92b4c1b2c1c36519", async() => {
                WriteLiteral("\r\n        <h2 class=\"sr-only\">Login Form</h2>\r\n        <div class=\"illustration\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d55c4beb3b7bb41de56c825d066c92b4c1b2c1c36862", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\r\n\r\n        <p>\r\n            Ol?? ");
#nullable restore
#line 23 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Home\ClienteLogado.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pessoa.NomePessoa));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <br /><strong>Ag??ncia:</strong> ");
#nullable restore
#line 24 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Home\ClienteLogado.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.NumeroAgencia));

#line default
#line hidden
#nullable disable
                WriteLiteral("  <br /> <strong>Conta:</strong> ");
#nullable restore
#line 24 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Home\ClienteLogado.cshtml"
                                                                                                                         Write(Html.DisplayFor(modelItem => item.NumeroConta));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n        </p>\r\n\r\n\r\n        <p><strong>Seu saldo dispon??vel</strong> </p>\r\n        <h4>\r\n            R$");
#nullable restore
#line 30 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Home\ClienteLogado.cshtml"
         Write(Html.DisplayFor(modelItem => item.SaldoPessoa.ValorSaldo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </h4>\r\n\r\n\r\n        <div class=\"form-group\">\r\n\r\n            <a class=\"btn btn-primary btn-block\" type=\"submit\"");
                BeginWriteAttribute("href", " href=\"", 935, "\"", 985, 1);
#nullable restore
#line 36 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Home\ClienteLogado.cshtml"
WriteAttributeValue("", 942, Url.Action("MovimentacaoBancaria", "Home"), 942, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                Fazer Transfer??ncia\r\n            </a>\r\n\r\n        </div>\r\n\r\n\r\n   ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 45 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Home\ClienteLogado.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BancoCunha.Models.Conta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
