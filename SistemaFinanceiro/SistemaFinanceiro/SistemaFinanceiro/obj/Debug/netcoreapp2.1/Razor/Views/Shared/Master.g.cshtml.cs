#pragma checksum "D:\Projetos\SistemaFinanceiro\SistemaFinanceiro\SistemaFinanceiro\Views\Shared\Master.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "382060b0a2be3e800e4860c6ade3a473decff4ca"
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
#line 1 "D:\Projetos\SistemaFinanceiro\SistemaFinanceiro\SistemaFinanceiro\Views\_ViewImports.cshtml"
using SistemaFinanceiro;

#line default
#line hidden
#line 2 "D:\Projetos\SistemaFinanceiro\SistemaFinanceiro\SistemaFinanceiro\Views\_ViewImports.cshtml"
using SistemaFinanceiro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"382060b0a2be3e800e4860c6ade3a473decff4ca", @"/Views/Shared/Master.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bcc233e264248253c36bd3257506e8199a0ad48", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Master : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1197, true);
            WriteLiteral(@"<link href=""//netdna.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//netdna.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js""></script>
<script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
<!------ Include the above in your HEAD tag ---------->

<link href=""//maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css"" rel=""stylesheet"">

<div class=""nav-side-menu"">
    <div class=""brand"">Tanga Frouxa</div>
    <i class=""fa fa-bars fa-2x toggle-btn"" data-toggle=""collapse"" data-target=""#menu-content""></i>

    <ul>
        <li>

        </li>
    </ul>

    <div class=""menu-list"">

        <ul id=""menu-content"" class=""menu-content collapse out"">
            <li>
                <a href=""#"">
                    <i class=""fas fa-igloo""></i> Home
                </a>
            </li>

            <li data-toggle=""collapse"" data-target=""#GeneralCad"" class=""collapsed active"">
                <a href=""#""><i c");
            WriteLiteral("lass=\"fa fa-gift fa-lg\"></i> Cadastros <span class=\"arrow\"></span></a>\r\n            </li>\r\n            <ul class=\"sub-menu collapse\" id=\"GeneralCad\">\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1197, "\"", 1262, 1);
#line 31 "D:\Projetos\SistemaFinanceiro\SistemaFinanceiro\SistemaFinanceiro\Views\Shared\Master.cshtml"
WriteAttributeValue("", 1204, Url.Action("Index","Usuario", new { area = "Cadastros" }), 1204, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1263, 511, true);
            WriteLiteral(@">Usuario</a></li>
                <li><a href=""#"">Tipo Lancamento</a></li>
            </ul>
            <li data-toggle=""collapse"" data-target=""#service"" class=""collapsed"">
                <a href=""#""><i class=""fa fa-globe fa-lg""></i> Lançamentos <span class=""arrow""></span></a>
            </li>
            <ul class=""sub-menu collapse"" id=""service"">
                <li><a href=""#"">Entrada</a></li>
                <li><a href=""#"">Saída</a></li>
            </ul>
        </ul>
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
