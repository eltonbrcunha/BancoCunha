#pragma checksum "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Pessoa\ContaCriada.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85e1849fd0373ddfd3455bc8daecd1948532d82a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa_ContaCriada), @"mvc.1.0.view", @"/Views/Pessoa/ContaCriada.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85e1849fd0373ddfd3455bc8daecd1948532d82a", @"/Views/Pessoa/ContaCriada.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1e4bd568346788f335f50c6788235f3bc523739", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoa_ContaCriada : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BancoCunha.Models.Conta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Pessoa\ContaCriada.cshtml"
  
    ViewBag.Title = "Banco Cunha - Seja bem vindo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85e1849fd0373ddfd3455bc8daecd1948532d82a3836", async() => {
                WriteLiteral("\r\n     \r\n        \r\n            <p>Parabéns  ");
#nullable restore
#line 11 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Pessoa\ContaCriada.cshtml"
                    Write(Html.DisplayFor(modelItem => Model.Pessoa.NomePessoa));

#line default
#line hidden
#nullable disable
                WriteLiteral(", a sua conta foi criada com sucesso!</p>\r\n\r\n            <p>Segue abaixo os dados da sua conta</p>\r\n\r\n            <p><strong>Correntista:</strong> ");
#nullable restore
#line 15 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Pessoa\ContaCriada.cshtml"
                                        Write(Html.DisplayFor(modelItem => Model.Pessoa.NomePessoa));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n            <p><strong>Agência:</strong>  ");
#nullable restore
#line 17 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Pessoa\ContaCriada.cshtml"
                                     Write(Html.DisplayFor(modelItem => Model.NumeroAgencia));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n\r\n            <p><strong>Conta:</strong> ");
#nullable restore
#line 19 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Pessoa\ContaCriada.cshtml"
                                  Write(Html.DisplayFor(modelItem => Model.NumeroConta));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n            <p><strong>Tipo de Conta:</strong> ");
#nullable restore
#line 21 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Pessoa\ContaCriada.cshtml"
                                          Write(Html.DisplayFor(modelItem => Model.Pessoa.TipoPessoa));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n            <p><strong>Data de Abertura:</strong> ");
#nullable restore
#line 23 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Pessoa\ContaCriada.cshtml"
                                             Write(Html.DisplayFor(modelItem => Model.DataAbertura));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n        \r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<p>Por favor, acesse a sua conta, usando o botão abaixo.</p>\r\n<a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 970, "\"", 1005, 1);
#nullable restore
#line 30 "C:\Users\ELTON\Documents\Visual Studio 2019\BancoCunha\Views\Pessoa\ContaCriada.cshtml"
WriteAttributeValue("", 977, Url.Action("Index", "Home"), 977, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    Continuar\r\n</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BancoCunha.Models.Conta> Html { get; private set; }
    }
}
#pragma warning restore 1591