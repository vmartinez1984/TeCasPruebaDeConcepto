#pragma checksum "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d81af53cf0142a3bb33bf4ffee623903bbbd510"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EstadosDeCuenta_Index), @"mvc.1.0.view", @"/Views/EstadosDeCuenta/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
using TeCAS.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d81af53cf0142a3bb33bf4ffee623903bbbd510", @"/Views/EstadosDeCuenta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61551066e601b3446c7d1f8c5ede160d76aaed97", @"/Views/_ViewImports.cshtml")]
    public class Views_EstadosDeCuenta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeCAS.Dtos.EstadoDeCuentaDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
  
    ViewData["Title"] = "Estado de cuenta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h2 class=\"text-info\">Estado de cuenta</h2>\r\n    </div>\r\n\r\n    <div class=\"card-body\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <p>");
#nullable restore
#line 18 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
              Write(Model.Cliente.Paterno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 19 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
              Write(Model.Cliente.Materno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 20 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
              Write(Model.Cliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <p>");
#nullable restore
#line 23 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
              Write(Model.Cliente.NumeroDeIdentificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 24 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
              Write(Model.Cliente.Rfc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 25 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
              Write(Model.CuentaDeAhorro.NumeroDeCuenta);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>
        <hr />
        <div>
            <div class=""row"">
                <div class=""col-md-12"">
                    <h3 class=""text-primary"">Movimientos</h3>

                    <table class=""table table-hover"">
                        <thead>
                            <tr>
                                <th>");
#nullable restore
#line 37 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.ListaDeTransacciones[0].FechaDeRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>                                
                                <th>Deposito</th>
                                <th>Retiro</th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th>");
#nullable restore
#line 44 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.ListaDeTransacciones[0].FechaDeRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>                                \r\n                                <th>Deposito</th>\r\n                                <th>Retiro</th>\r\n                            </tr>\r\n                        </tfoot>\r\n                        <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
                             foreach (var item in Model.ListaDeTransacciones)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 53 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
                                   Write(item.FechaDeRegistro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                                    \r\n");
#nullable restore
#line 54 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
                                     if (item.TransaccionId == TransaccionDto.Deposito)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 56 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
                                       Write(item.Monto.ToString("C", CultureInfo.CreateSpecificCulture("es-MX")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td></td>\r\n");
#nullable restore
#line 58 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td></td>\r\n                                        <td>");
#nullable restore
#line 62 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
                                       Write(item.Monto.ToString("C", CultureInfo.CreateSpecificCulture("es-MX")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 63 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n");
#nullable restore
#line 65 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-info\">Total de depositos</td>                                \r\n                                <td>");
#nullable restore
#line 68 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
                               Write(Model.ListaDeTransacciones.Where(x=> x.TransaccionId == TransaccionDto.Deposito).Sum(x=>x.Monto).ToString("C", CultureInfo.CreateSpecificCulture("es-MX")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                <td></td>
                            </tr>
                            <tr>
                                <td class=""text-info"">Total de retiros</td>                                
                                <td></td>
                                <td>");
#nullable restore
#line 74 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
                               Write(Model.ListaDeTransacciones.Where(x=> x.TransaccionId == TransaccionDto.Retiro).Sum(x=>x.Monto).ToString("C", CultureInfo.CreateSpecificCulture("es-MX")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"card-footer\">\r\n        <p>Saldo a la fecha: ");
#nullable restore
#line 85 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
                        Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <h2 class=\"text-info\">");
#nullable restore
#line 86 "C:\Users\vmartinez\Source\Repos\vmartinez1984\TeCasPruebaDeConcepto\TeCAS\Views\EstadosDeCuenta\Index.cshtml"
                         Write(Model.CuentaDeAhorro.SaldoActual.ToString("C", CultureInfo.CreateSpecificCulture("es-MX")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeCAS.Dtos.EstadoDeCuentaDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
