using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TeCAS.BussinesLayer;
using TeCAS.Dtos;

namespace TeCAS.Controllers
{
    public class ClientesController : Controller
    {
        public async Task<IActionResult> Index(BusquedaDeClienteDto busquedaDeClienteDto)
        {
            ListaDeClientesDto listaDeClientesDto;

            listaDeClientesDto = await ClienteBl.Obtener(busquedaDeClienteDto);

            return View(listaDeClientesDto);
        }

        public async Task<IActionResult> Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(ClienteDto clienteDto)
        {
            if (ModelState.IsValid)
            {
                ClienteBl.AgregarAsync(clienteDto);

                return RedirectToAction();
            }
            else
            {
                return View();
            }
        }

    }//end class
}