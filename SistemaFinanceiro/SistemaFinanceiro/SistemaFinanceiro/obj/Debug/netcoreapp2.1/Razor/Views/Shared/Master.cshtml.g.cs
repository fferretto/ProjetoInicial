#pragma checksum "C:\Users\tiegh\Desktop\Projetos\ProjetoInicial\SistemaFinanceiro\SistemaFinanceiro\SistemaFinanceiro\Views\Shared\Master.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c76997b63eea9195be3de7f6984f799de0e2283f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Master), @"mvc.1.0.view", @"/Views/Shared/Master.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Master.cshtml", typeof(AspNetCore.Views_Shared_Master))]
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
#line 1 "C:\Users\tiegh\Desktop\Projetos\ProjetoInicial\SistemaFinanceiro\SistemaFinanceiro\SistemaFinanceiro\Views\_ViewImports.cshtml"
using SistemaFinanceiro;

#line default
#line hidden
#line 2 "C:\Users\tiegh\Desktop\Projetos\ProjetoInicial\SistemaFinanceiro\SistemaFinanceiro\SistemaFinanceiro\Views\_ViewImports.cshtml"
using SistemaFinanceiro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c76997b63eea9195be3de7f6984f799de0e2283f", @"/Views/Shared/Master.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bcc233e264248253c36bd3257506e8199a0ad48", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Master : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/header.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 104, true);
            WriteLiteral("\r\n<link href=\"//maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css\" rel=\"stylesheet\">\r\n");
            EndContext();
            BeginContext(104, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b5d13f0b6434b4ea6f966bc62d5bbbb", async() => {
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
            EndContext();
            BeginContext(153, 856, true);
            WriteLiteral(@"

<div class=""menu-list"">
    
    <div class=""menu-list"">
        <header tabindex=""0"">Tanga Frouxa</header>
        <div id=""nav-container"">
            <div class=""bg""></div>
            <div class=""button"" tabindex=""0"">
                <span class=""icon-bar""></span>
                <span class=""icon-bar""></span>
                <span class=""icon-bar""></span>
            </div>
            <nav id=""nav-content"" class=""sidebar-nav"" tabindex=""0"">
                <ul>
                    <li>
                        <a href=""#""><i class=""fa fa-home""></i><span>Home</span></a>
                    </li>
                    <li>
                        <a><i class=""fa fa-gift fa-lg""></i><span>Cadastros</span></a>
                        <ul class=""nav-flyout"">
                            <li>
                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1009, "\"", 1074, 1);
#line 25 "C:\Users\tiegh\Desktop\Projetos\ProjetoInicial\SistemaFinanceiro\SistemaFinanceiro\SistemaFinanceiro\Views\Shared\Master.cshtml"
WriteAttributeValue("", 1016, Url.Action("Index","Usuario", new { area = "Cadastros" }), 1016, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1075, 803, true);
            WriteLiteral(@">Usuarios</a>
                            </li>
                            <li>
                                <a href=""#"">Tipo Lancamento</a>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <a><i class=""fa fa-globe fa-lg""></i> <span class="""">Lançamentos </span></a>
                        <ul class=""nav-flyout"">
                            <li>
                                <a href=""#"">Entrada</a>
                            </li>
                            <li>
                                <a href=""#"">Saida</a>
                            </li>
                        </ul>
                    </li>
                </ul>
            </nav>
        </div>
    </div>
</div>");
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
