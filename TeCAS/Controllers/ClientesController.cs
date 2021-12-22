using Microsoft.AspNetCore.Http;
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

        public IActionResult Agregar()
        {
            if (HttpContext.Session.GetInt32("usuarioId") is null)
            {
                return RedirectToAction("Index", "InicioDeSesion");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Agregar(ClienteDto clienteDto)
        {
            if (HttpContext.Session.GetInt32("usuarioId") is null)
            {
                return RedirectToAction("Index", "InicioDeSesion");
            }

            clienteDto.UsuarioId = (int) HttpContext.Session.GetInt32("usuarioId");
            if (ModelState.IsValid)
            {
                await ClienteBl.AgregarAsync(clienteDto);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

    }//end class
}