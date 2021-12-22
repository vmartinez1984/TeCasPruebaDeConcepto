using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeCAS.Models
{
    public class CuentaDeAhorroDetalle
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(CuentaDeAhorro))]
        public int CuentaDeAhorroId { get; set; }

        [Required]
        public decimal Monto { get; set; }

       [ForeignKey(nameof(CuentaDeAhorroTransaccion))]
        public int TransaccionId { get; set; }

        public DateTime FechaDeRegistro { get; set; }

        [ForeignKey(nameof(Usuario))]
        public int UsuarioId { get; set; }
    }
}
