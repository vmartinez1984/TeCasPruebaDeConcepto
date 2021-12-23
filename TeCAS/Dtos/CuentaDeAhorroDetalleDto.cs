using System.ComponentModel.DataAnnotations;
using TeCAS.Validations;

namespace TeCAS.Dtos
{
    public class CuentaDeAhorroDetalleDto
    {
        [Required]
        public int CuentaDeAhorroId { get;  set; }

        [Required]
        [Range(1, (double)decimal.MaxValue )]
        [DataType(DataType.Currency)]
        [ValidarRetiroYSaldoAttribute]
        public decimal Monto { get;  set; }
        [Required]
        public int UsuarioId { get;  set; }

        public int TransaccionId { get; set; }

    }
}
