using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TeCAS.Dtos;
using TeCAS.Models;

namespace TeCAS.BussinesLayer
{
    public class UsuarioBl
    {
        internal static async Task<UsuarioDto> IniciarSesionAsync(InicioDeSesionDto inicioDeSesion)
        {
            try
            {
                UsuarioDto usuarioDto;

                using (var db = new AppDbContext())
                {
                    usuarioDto = await db.Usuario.Where(x => x.Usuario == inicioDeSesion.Usuario && x.Contrasenia == inicioDeSesion.Contrasenia).Select(x => Obtener(x)).FirstOrDefaultAsync();
                }

                return usuarioDto;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static UsuarioDto Obtener(Usuario x)
        {
            return new UsuarioDto
            {
                Id = x.Id,
                Materno = x.Materno,
                Nombre = x.Nombre,
                Paterno = x.Paterno
            };
        }
    }
}
