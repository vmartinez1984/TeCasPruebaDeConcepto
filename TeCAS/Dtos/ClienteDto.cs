using System.ComponentModel.DataAnnotations;

namespace TeCAS.Dtos
{
    public class ClienteDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Paterno")]
        [MaxLength(50)]
        public string Paterno { get; set; }

        [Display(Name = "Materno")]
        [MaxLength(50)]
        public string Materno { get; set; }

        [Required]
        [Display(Name = "RFC")]
        [MaxLength(13)]
        public string Rfc { get; set; }

        [Required]
        [Display(Name = "Número de identificación")]
        [MaxLength(20)]
        public string NumeroDeIdentificacion { get; set; }
        public int UsuarioId { get; internal set; }
    }
}
