using System;
using System.ComponentModel.DataAnnotations;

namespace TeCAS.Dtos
{
    public class CuentaDeAhorroDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Número de cuenta")]
        public string NumeroDeCuenta { get; set; }

        [Required]
        [Range(0, (double)decimal.MaxValue)]
        [Display(Name ="Saldo actual")]
        public decimal SaldoActual { get; set; }

        [Required]
        [Display(Name = "Fecha de registro")]
        public DateTime FechaDeRegistro { get; set; }

        public int UsuarioId { get; set; }
    }
}