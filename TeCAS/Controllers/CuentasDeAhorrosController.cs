using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeCAS.BussinesLayer;
using TeCAS.Dtos;

namespace TeCAS.Controllers
{
    public class CuentasDeAhorrosController : Controller
    {
        public async Task<IActionResult> Index(int clienteId)
        {
            if (HttpContext.Session.GetInt32("usuarioId") is null)
            {
                return RedirectToAction("Index", "InicioDeSesion");
            }

            List<CuentaDeAhorroDto> lista;

            lista = await CuentaDeAhorroBl.ObtenerAsync(clienteId);
            ViewBag.ClienteId = clienteId;

            return View(lista);
        }

        public async Task<IActionResult> Agregar(int clienteId)
        {
            if (HttpContext.Session.GetInt32("usuarioId") is null)
            {
                return RedirectToAction("Index", "InicioDeSesion");
            }

            await CuentaDeAhorroBl.AgregarAsync(clienteId,(int)HttpContext.Session.GetInt32("usuarioId"));

            return RedirectToAction("Index");
        }
    }
}
