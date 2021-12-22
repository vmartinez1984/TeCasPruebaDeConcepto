using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TeCAS.BussinesLayer;
using TeCAS.Dtos;

namespace TeCAS.Controllers
{
    public class InicioDeSesionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>  Index(InicioDeSesionDto inicioDeSesionDto)
        {
            try
            {
				if (ModelState.IsValid)
				{
					UsuarioDto usuarioDto;

					usuarioDto = await UsuarioBl.IniciarSesionAsync(inicioDeSesionDto);
					if (usuarioDto is null)
					{
						ViewBag.Error = "Usuario y/o contraseña no validos";
						return View();
					}
					else
					{
						HttpContext.Session.SetInt32("usuarioId", usuarioDto.Id);			
						HttpContext.Session.SetString("usuarioNombre", $"{usuarioDto.Nombre} {usuarioDto.Paterno} {usuarioDto.Materno}".Trim());

						return RedirectToAction("Index", "Home");
					}
				}
				else
				{
					return View();
				}
			}
            catch (System.Exception)
            {

                throw;
            }
        }

		public IActionResult CerrarSesion()
		{
			HttpContext.Session.Clear();

			return RedirectToAction("Index");
		}
	}
}