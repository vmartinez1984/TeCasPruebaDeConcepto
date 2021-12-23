using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TeCAS.BussinesLayer;
using TeCAS.Dtos;

namespace TeCAS.Controllers
{
    public class CuentaDeAhorroDetallesController : Controller
    {
        public IActionResult Depositar(int cuentaDeAhorroId)
        {
            try
            {
                if (HttpContext.Session.GetInt32("usuarioId") is null)
                {
                    return RedirectToAction("Index", "InicioDeSesion");
                }
                ViewBag.ClienteId = ClienteBl.ObtenerId(cuentaDeAhorroId);

                return View(new CuentaDeAhorroDetalleDto { CuentaDeAhorroId = cuentaDeAhorroId });
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Depositar(CuentaDeAhorroDetalleDto cuentaDeAhorroDetalle)
        {
            try
            {
                if (HttpContext.Session.GetInt32("usuarioId") is null)
                {
                    return RedirectToAction("Index", "InicioDeSesion");
                }
                
                if (ModelState.IsValid)
                {

                    int clienteId;

                    cuentaDeAhorroDetalle.UsuarioId = (int)HttpContext.Session.GetInt32("usuarioId");
                    await CuentaDeAhorroDetalleBl.Depositar(cuentaDeAhorroDetalle);
                    clienteId = ClienteBl.ObtenerId(cuentaDeAhorroDetalle.CuentaDeAhorroId);

                    return RedirectToAction("Index", "CuentasDeAhorros", new { clienteId = clienteId });
                }
                else
                {
                    ViewBag.ClienteId = ClienteBl.ObtenerId(cuentaDeAhorroDetalle.CuentaDeAhorroId);

                    return View(new CuentaDeAhorroDetalleDto { CuentaDeAhorroId = cuentaDeAhorroDetalle.CuentaDeAhorroId });
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public IActionResult Retirar(int cuentaDeAhorroId)
        {
            try
            {
                if (HttpContext.Session.GetInt32("usuarioId") is null)
                {
                    return RedirectToAction("Index", "InicioDeSesion");
                }
                ViewBag.ClienteId = ClienteBl.ObtenerId(cuentaDeAhorroId);
                ViewBag.SaldoActual = CuentaDeAhorroBl.ObtenerSaldoActual(cuentaDeAhorroId);

                return View(new CuentaDeAhorroDetalleDto { CuentaDeAhorroId = cuentaDeAhorroId });
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Retirar(CuentaDeAhorroDetalleDto cuentaDeAhorroDetalle)
        {
            try
            {
                if (HttpContext.Session.GetInt32("usuarioId") is null)
                {
                    return RedirectToAction("Index", "InicioDeSesion");
                }

                if (ModelState.IsValid)
                {

                    int clienteId;

                    cuentaDeAhorroDetalle.UsuarioId = (int)HttpContext.Session.GetInt32("usuarioId");
                    await CuentaDeAhorroDetalleBl.RetirarAsync(cuentaDeAhorroDetalle);
                    clienteId = ClienteBl.ObtenerId(cuentaDeAhorroDetalle.CuentaDeAhorroId);

                    return RedirectToAction("Index", "CuentasDeAhorros", new { clienteId = clienteId });
                }
                else
                {
                    ViewBag.ClienteId = ClienteBl.ObtenerId(cuentaDeAhorroDetalle.CuentaDeAhorroId);
                    ViewBag.SaldoActual = CuentaDeAhorroBl.ObtenerSaldoActual(cuentaDeAhorroDetalle.CuentaDeAhorroId);

                    return View(new CuentaDeAhorroDetalleDto { CuentaDeAhorroId = cuentaDeAhorroDetalle.CuentaDeAhorroId });
                }

            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
