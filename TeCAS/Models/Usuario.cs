using System.ComponentModel.DataAnnotations;

namespace TeCAS.Models
{
    public class Usuario: Persona
    {
        [Required]
        [StringLength(20)]
        public string NumeroDeEmpleado { get; set; }
    }
}