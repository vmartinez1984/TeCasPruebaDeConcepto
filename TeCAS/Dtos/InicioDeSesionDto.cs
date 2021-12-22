using System.ComponentModel.DataAnnotations;

namespace TeCAS.Dtos
{
    public class InicioDeSesionDto
    {
        [Required]
        [Display(Name ="Usuario")]
        public string Usuario { get; set; }

        [Required]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Contrasenia { get; set; }
    }
}