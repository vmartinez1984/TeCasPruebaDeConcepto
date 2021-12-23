using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TeCAS.Dtos;
using TeCAS.Models;

namespace TeCAS.BussinesLayer
{
    public class CuentaDeAhorroDetalleBl
    {
        public static async Task<int> Depositar(CuentaDeAhorroDetalleDto cuentaDeAhorroDetalleDto)
        {
            try
            {
                CuentaDeAhorroDetalle cuentaDeAhorroDetalle;

                cuentaDeAhorroDetalle = new CuentaDeAhorroDetalle
                {
                    CuentaDeAhorroId = cuentaDeAhorroDetalleDto.CuentaDeAhorroId,
                    FechaDeRegistro = DateTime.Now,
                    Monto = (decimal)cuentaDeAhorroDetalleDto.Monto,
                    TransaccionId = TransaccionDto.Deposito,
                    UsuarioId = cuentaDeAhorroDetalleDto.UsuarioId
                };

                using (var db = new AppDbContext())
                {
                    db.CuentaDeAhorroDetalle.Add(cuentaDeAhorroDetalle);
                    await db.SaveChangesAsync();
                    //Actualizamos el saldo
                    CuentaDeAhorro cuentaDeAhorro;

                    cuentaDeAhorro = await db.CuentaDeAhorro
                         .Where(x => x.Id == cuentaDeAhorroDetalleDto.CuentaDeAhorroId)
                         .FirstOrDefaultAsync();
                    cuentaDeAhorro.SaldoActual += cuentaDeAhorroDetalle.Monto;
                    await db.SaveChangesAsync();
                }

                return cuentaDeAhorroDetalle.Id;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
