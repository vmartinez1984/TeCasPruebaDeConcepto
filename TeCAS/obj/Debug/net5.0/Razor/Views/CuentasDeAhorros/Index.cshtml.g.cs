#pragma checksum "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7a154aa8d1cc293fcb733ab3bfc4f822856a19d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CuentasDeAhorros_Index), @"mvc.1.0.view", @"/Views/CuentasDeAhorros/Index.cshtml")]
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
#line 1 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\_ViewImports.cshtml"
using TeCAS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\_ViewImports.cshtml"
using TeCAS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7a154aa8d1cc293fcb733ab3bfc4f822856a19d", @"/Views/CuentasDeAhorros/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61551066e601b3446c7d1f8c5ede160d76aaed97", @"/Views/_ViewImports.cshtml")]
    public class Views_CuentasDeAhorros_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TeCAS.Dtos.CuentaDeAhorroDto>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7a154aa8d1cc293fcb733ab3bfc4f822856a19d3527", async() => {
                WriteLiteral("Agregar nueva cuenta");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 131, "~/CuentasDeAhorros/Agregar?clienteId=", 131, 37, true);
#nullable restore
#line 10 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml"
AddHtmlAttributeValue("", 168, ViewBag.ClienteId, 168, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumeroDeCuenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SaldoActual));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaDeRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumeroDeCuenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SaldoActual));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechaDeRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml"
               Write(Html.ActionLink("Depositar", "Depositar", "CuentaDeAhorroDetalles", new { cuentaDeAhorroId = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 42 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml"
               Write(Html.ActionLink("Retirar", "Retirar","CuentaDeAhorroDetalles", new {  cuentaDeAhorroId=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 43 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml"
               Write(Html.ActionLink("Estado de cuenta", "EstadoDeCuenta","CuentaDeAhorroDetalles", new {  cuentaDeAhorroId=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml"
                     if (item.SaldoActual == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>|</span>\r\n");
#nullable restore
#line 48 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml"
                   Write(Html.ActionLink("Borrar", "Borrar", new {  id=item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml"
                                                                                 
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\CuentasDeAhorros\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TeCAS.Dtos.CuentaDeAhorroDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
