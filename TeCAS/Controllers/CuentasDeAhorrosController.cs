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

            lista = await CuentaDeAhorroBl.ObtenerListaAsync(clienteId);
            ViewBag.ClienteId = clienteId;

            return View(lista);
        }

        public async Task<IActionResult> Agregar(int clienteId)
        {
            if (HttpContext.Session.GetInt32("usuarioId") is null)
            {
                return RedirectToAction("Index", "InicioDeSesion");
            }

            await CuentaDeAhorroBl.AgregarAsync(clienteId, (int)HttpContext.Session.GetInt32("usuarioId"));

            return RedirectToAction("Index", "CuentasDeAhorros", new { clienteId = clienteId });
        }

        public async Task<IActionResult> Borrar(int id)
        {
            if (HttpContext.Session.GetInt32("usuarioId") is null)
            {
                return RedirectToAction("Index", "InicioDeSesion");
            }

            try
            {
                CuentaDeAhorroDto cuentaDeAhorro;

                cuentaDeAhorro = await CuentaDeAhorroBl.ObtenerAsync(id);

                return View(cuentaDeAhorro);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Borrar(CuentaDeAhorroDto cuentaDeAhorro)
        {
            try
            {
                if (HttpContext.Session.GetInt32("usuarioId") is null)
                {
                    return RedirectToAction("Index", "InicioDeSesion");
                }

                await CuentaDeAhorroBl.BorrarAsync(cuentaDeAhorro.Id);

                return RedirectToAction("Index", "CuentasDeAhorros", new { clienteId = cuentaDeAhorro.ClienteId });
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
