using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeCAS.Models
{
    public class CuentaDeAhorro
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Cliente))]
        [Required]
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(20)]
        public string NumeroDeCuenta { get; set; }

        [Required]
        [Range(0, (double)decimal.MaxValue)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SaldoActual { get; set; }

        [Required]
        public DateTime  FechaDeRegistro { get; set; }
               
        public DateTime FechaDeBaja { get; set; }

        [Required]
        public bool EstaActivo { get; set; }

        [ForeignKey(nameof(Usuario))]
        public int UsuarioId { get; set; }
    }
}