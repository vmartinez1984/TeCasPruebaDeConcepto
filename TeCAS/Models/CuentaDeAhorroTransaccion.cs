using System.ComponentModel.DataAnnotations;

namespace TeCAS.Models
{
    public class CuentaDeAhorroTransaccion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(255)]
        public string Descripcion { get; set; }

    }//end class
}
