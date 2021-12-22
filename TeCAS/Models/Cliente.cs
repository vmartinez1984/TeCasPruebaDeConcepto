using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeCAS.Models
{
    public class Cliente: Persona
    {      
        [Required]
        [MaxLength(20)]
        public string NumeroDeIdentificacion { get; set; }

        [Required]
        [StringLength(20)]
        public string Clabe { get; set; }

        [ForeignKey(nameof(Usuario))]
        public int UsuarioId { get; set; }

    }
}