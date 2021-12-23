using System;
using System.ComponentModel.DataAnnotations;
using TeCAS.BussinesLayer;
using TeCAS.Validations;

namespace TeCAS.Dtos
{
    public class CuentaDeAhorroDetalleDto
    {
        [Required]
        public int CuentaDeAhorroId { get; set; }

        [Required]
        //[Range(1, (double)decimal.MaxValue)]
        //[DataType(DataType.Currency)]
        [ValidarRetiroYSaldoAttribute]
        public double Monto
        {
            get { return string.IsNullOrEmpty(MontoFormateado)? monto: MontoBl.Obtener(MontoFormateado); }
            set { monto = value; }
        }
        private double monto;

        [Required]
        [MaxLength(10)]
        [ValidarMonto]
        [Display(Name ="Monto")]
        public string MontoFormateado { get; set; }


        [Required]
        public int UsuarioId { get; set; }

        public int TransaccionId { get; set; }

        [Display(Name = "Transacción")]
        public string Transaccion { get; set; }

        [Display(Name = "Fecha de registro")]
        public DateTime FechaDeRegistro { get; set; }
    }
}
