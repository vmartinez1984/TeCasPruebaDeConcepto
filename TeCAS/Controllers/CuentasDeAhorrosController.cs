using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeCAS.BussinesLayer;
using TeCAS.Dtos;

namespace TeCAS.Controllers
{
    public class CuentasDeAhorrosController : Controller
    {
        public async Task<IActionResult> Lista(int clienteId)
        {
            List<CuentaDeAhorroDto> lista;

            lista = await CuentaDeAhorroBl.ObtenerAsync(clienteId);

            return View();
        }
    }
}
