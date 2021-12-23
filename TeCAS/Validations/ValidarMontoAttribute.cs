using System;
using System.ComponentModel.DataAnnotations;
using TeCAS.BussinesLayer;

namespace TeCAS.Validations
{
    public class ValidarMontoAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {            
            string montoFormateado;
            double monto;

            montoFormateado = value as string;  
            monto = MontoBl.Obtener(montoFormateado);
            if (monto > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
