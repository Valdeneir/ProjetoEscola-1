#pragma checksum "C:\Users\Valdeneir\Documents\NovosProjetos\Escola\ProEscola\ProEscola\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5b0da6570c8d5867d2b070c5f5dbdf1a817bc41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Valdeneir\Documents\NovosProjetos\Escola\ProEscola\ProEscola\Views\_ViewImports.cshtml"
using ProEscola;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Valdeneir\Documents\NovosProjetos\Escola\ProEscola\ProEscola\Views\_ViewImports.cshtml"
using ProEscola.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5b0da6570c8d5867d2b070c5f5dbdf1a817bc41", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f32b672dbca0d46fa84a18d3cc8d291b0f7825ce", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Valdeneir\Documents\NovosProjetos\Escola\ProEscola\ProEscola\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Bem Vindo, ");
#nullable restore
#line 8 "C:\Users\Valdeneir\Documents\NovosProjetos\Escola\ProEscola\ProEscola\Views\Home\Index.cshtml"
                                Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </></h1>\r\n    <p>Você está no site Criado por Mr.Wendell</p>\r\n    <span>Seu Email: ");
#nullable restore
#line 10 "C:\Users\Valdeneir\Documents\NovosProjetos\Escola\ProEscola\ProEscola\Views\Home\Index.cshtml"
                Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591