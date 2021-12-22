using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeCAS.Dtos;
using TeCAS.Models;

namespace TeCAS.BussinesLayer
{
    public class CuentaDeAhorroBl
    {
        internal static async Task<List<CuentaDeAhorroDto>> ObtenerAsync(int clienteId)
        {
            try
            {
                List<CuentaDeAhorroDto> lista;

                using (var db = new AppDbContext())
                {
                    lista = await db.CuentaDeAhorro.Where(x => x.ClienteId == clienteId)
                        .Select(x => new CuentaDeAhorroDto
                        {
                            Id = x.ClienteId,
                            ClienteId = x.ClienteId,
                            FechaDeRegistro = x.FechaDeRegistro,
                            NumeroDeCuenta = x.NumeroDeCuenta,
                            SaldoActual = x.SaldoActual,
                            UsuarioId = x.UsuarioId
                        })
                        .ToListAsync();
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal static async Task<int> AgregarAsync(int clienteId, int usuarioId)
        {
            try
            {
                CuentaDeAhorro cuentaDeAhorro;

                cuentaDeAhorro = new CuentaDeAhorro
                {
                    ClienteId = clienteId,
                    EstaActivo = true,
                    FechaDeRegistro = DateTime.Now,
                    NumeroDeCuenta = string.Empty,
                    SaldoActual = 0,
                    UsuarioId = usuarioId
                };
                using (var db = new AppDbContext())
                {
                    db.CuentaDeAhorro.Add(cuentaDeAhorro);
                    await db.SaveChangesAsync();
                    cuentaDeAhorro.NumeroDeCuenta = ObtenerNumeroDeCuenta(cuentaDeAhorro.Id);
                    await db.SaveChangesAsync();
                }

                return cuentaDeAhorro.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static string ObtenerNumeroDeCuenta(int id)
        {
            try
            {
                return $"{DateTime.Now.Year} {id.ToString().PadLeft(4, '0')}";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
