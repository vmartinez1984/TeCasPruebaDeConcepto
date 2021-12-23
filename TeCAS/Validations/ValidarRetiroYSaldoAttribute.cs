using System.ComponentModel.DataAnnotations;
using TeCAS.BussinesLayer;
using TeCAS.Dtos;

namespace TeCAS.Validations
{
    public class ValidarRetiroYSaldoAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            decimal saldoActual;
            CuentaDeAhorroDetalleDto cuentaDeAhorroDetalle;

            cuentaDeAhorroDetalle = (CuentaDeAhorroDetalleDto)validationContext.ObjectInstance;
            if (cuentaDeAhorroDetalle.TransaccionId == TransaccionDto.Retiro)
            {
                saldoActual = CuentaDeAhorroBl.ObtenerSaldoActual(cuentaDeAhorroDetalle.CuentaDeAhorroId);
                if (saldoActual > cuentaDeAhorroDetalle.Monto)
                {
                    return ValidationResult.Success;
                }
                else if (saldoActual == cuentaDeAhorroDetalle.Monto)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("El retiro no puede ser mayor que el saldo");
                }
            }
            else
            {
                return ValidationResult.Success;
            }
        }

    }//end class
}