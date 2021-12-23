using System;

namespace TeCAS.BussinesLayer
{
    public class MontoBl
    {
        public static double Obtener(string montoFormateado)
        {
            double monto;
       
            montoFormateado = montoFormateado.Trim();
            montoFormateado = montoFormateado.Replace("$", string.Empty);
            montoFormateado = montoFormateado.Replace(",", string.Empty);
            montoFormateado = montoFormateado.Replace(".", ",");
            monto = Convert.ToDouble(montoFormateado);

            return monto;
        }
    }
}
