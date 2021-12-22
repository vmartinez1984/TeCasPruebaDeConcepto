using System;
using System.ComponentModel.DataAnnotations;

namespace TeCAS.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Paterno { get; set; }

        [MaxLength(50)]
        public string Materno { get; set; }

        [Required]
        [MaxLength(13)]
        public string Rfc { get; set; }

        [Required]
        [MaxLength(20)]
        public string Usuario { get; set; }

        [Required]
        [MaxLength(20)]
        public string Contrasenia { get; set; }

        [Required]
        public DateTime FechaDeRegistro { get; set; }
    }
}
