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

            lista = CuentaDeAhorroBl.ObtenerAsync(clienteId)

            return View();
        }
    }
}
