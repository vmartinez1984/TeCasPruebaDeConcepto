using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TeCAS.BussinesLayer;
using TeCAS.Dtos;

namespace TeCAS.Controllers
{
    public class EstadosDeCuentaController : Controller
    {
        public async Task<IActionResult> Index(int cuentaDeAhorroId)
        {
            if (HttpContext.Session.GetInt32("usuarioId") is null)
            {
                return RedirectToAction("Index", "InicioDeSesion");
            }

            EstadoDeCuentaDto estadoDeCuenta;

            estadoDeCuenta = await CuentaDeAhorroBl.ObtenerEstadoDeCuentaAsync(cuentaDeAhorroId);

            return View(estadoDeCuenta);
        }
    }
}
