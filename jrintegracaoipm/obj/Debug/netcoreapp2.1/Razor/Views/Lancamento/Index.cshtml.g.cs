#pragma checksum "C:\Users\ValeAzul\source\repos\jrintegracaoipm\jrintegracaoipm\Views\Lancamento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc431bf4400af9c883868bf825e83bde45e34a9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lancamento_Index), @"mvc.1.0.view", @"/Views/Lancamento/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lancamento/Index.cshtml", typeof(AspNetCore.Views_Lancamento_Index))]
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
#line 1 "C:\Users\ValeAzul\source\repos\jrintegracaoipm\jrintegracaoipm\Views\_ViewImports.cshtml"
using jrintegracaoipm;

#line default
#line hidden
#line 2 "C:\Users\ValeAzul\source\repos\jrintegracaoipm\jrintegracaoipm\Views\_ViewImports.cshtml"
using jrintegracaoipm.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc431bf4400af9c883868bf825e83bde45e34a9b", @"/Views/Lancamento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c82955548c2233a7d5b4591764e857a18ded7b76", @"/Views/_ViewImports.cshtml")]
    public class Views_Lancamento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<jrintegracaoipm.Models.Lancamento>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\ValeAzul\source\repos\jrintegracaoipm\jrintegracaoipm\Views\Lancamento\Index.cshtml"
  
    ViewData ["Title"] = "Lancamento";

#line default
#line hidden
            BeginContext(172, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(229, 116, true);
            WriteLiteral("\r\n\r\n\r\n<table class=\"table table-striped table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(346, 45, false);
#line 17 "C:\Users\ValeAzul\source\repos\jrintegracaoipm\jrintegracaoipm\Views\Lancamento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CliCodigo));

#line default
#line hidden
            EndContext();
            BeginContext(391, 56, true);
            WriteLiteral(";\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(448, 42, false);
#line 20 "C:\Users\ValeAzul\source\repos\jrintegracaoipm\jrintegracaoipm\Views\Lancamento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LoaAno));

#line default
#line hidden
            EndContext();
            BeginContext(490, 56, true);
            WriteLiteral(";\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(547, 44, false);
#line 23 "C:\Users\ValeAzul\source\repos\jrintegracaoipm\jrintegracaoipm\Views\Lancamento\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LanValor));

#line default
#line hidden
            EndContext();
            BeginContext(591, 68, true);
            WriteLiteral(";\r\n            </th>\r\n\r\n        </tr>\r\n\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 30 "C:\Users\ValeAzul\source\repos\jrintegracaoipm\jrintegracaoipm\Views\Lancamento\Index.cshtml"
         foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(712, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(773, 44, false);
#line 34 "C:\Users\ValeAzul\source\repos\jrintegracaoipm\jrintegracaoipm\Views\Lancamento\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CliCodigo));

#line default
#line hidden
            EndContext();
            BeginContext(817, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(885, 41, false);
#line 37 "C:\Users\ValeAzul\source\repos\jrintegracaoipm\jrintegracaoipm\Views\Lancamento\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LoaAno));

#line default
#line hidden
            EndContext();
            BeginContext(926, 46, true);
            WriteLiteral("\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(973, 43, false);
#line 40 "C:\Users\ValeAzul\source\repos\jrintegracaoipm\jrintegracaoipm\Views\Lancamento\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LanValor));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 21, true);
            WriteLiteral("\r\n            </tr>\r\n");
            EndContext();
#line 42 "C:\Users\ValeAzul\source\repos\jrintegracaoipm\jrintegracaoipm\Views\Lancamento\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1052, 28, true);
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<jrintegracaoipm.Models.Lancamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591