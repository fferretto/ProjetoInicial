#pragma checksum "D:\Projetos\ProjetoInicial\SistemaFinanceiro\Views\Shared\_Modal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e8ec3fc3f3beb1d71a94a26907badd20dde2c8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Modal), @"mvc.1.0.view", @"/Views/Shared/_Modal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Modal.cshtml", typeof(AspNetCore.Views_Shared__Modal))]
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
#line 1 "D:\Projetos\ProjetoInicial\SistemaFinanceiro\Views\_ViewImports.cshtml"
using SistemaFinanceiro;

#line default
#line hidden
#line 2 "D:\Projetos\ProjetoInicial\SistemaFinanceiro\Views\_ViewImports.cshtml"
using SistemaFinanceiro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e8ec3fc3f3beb1d71a94a26907badd20dde2c8f", @"/Views/Shared/_Modal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bcc233e264248253c36bd3257506e8199a0ad48", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Modal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 259, true);
            WriteLiteral(@"
<div class=""modal-dialog"">
    <div class=""modal-content"">
        <div class=""modal-header"">
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
            <h4 class=""modal-title"" id=""myModalLabel"">");
            EndContext();
            BeginContext(260, 14, false);
#line 6 "D:\Projetos\ProjetoInicial\SistemaFinanceiro\Views\Shared\_Modal.cshtml"
                                                 Write(ViewBag.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(274, 71, true);
            WriteLiteral("</h4>\r\n        </div>\r\n        <div class=\"modal-body\">\r\n\r\n            ");
            EndContext();
            BeginContext(346, 12, false);
#line 10 "D:\Projetos\ProjetoInicial\SistemaFinanceiro\Views\Shared\_Modal.cshtml"
       Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(358, 68, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"modal-footer\">\r\n            ");
            EndContext();
            BeginContext(427, 30, false);
#line 14 "D:\Projetos\ProjetoInicial\SistemaFinanceiro\Views\Shared\_Modal.cshtml"
       Write(RenderSection("footer", false));

#line default
#line hidden
            EndContext();
            BeginContext(457, 135, true);
            WriteLiteral("\r\n            <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Close</button>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
