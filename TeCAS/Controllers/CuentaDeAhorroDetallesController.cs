using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeCAS.BussinesLayer;
using TeCAS.Dtos;

namespace TeCAS.Controllers
{
    public class CuentaDeAhorroDetallesController : Controller
    {
        public async Task<IActionResult> Index(int clienteId)
        {
            List<CuentaDeAhorroDto> lista;

            lista = await CuentaDeAhorroBl.ObtenerAsync(clienteId);

            return View(lista);
        }

        public IActionResult Agregar(int clienteId)
        {
            try
            {
                return View();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
