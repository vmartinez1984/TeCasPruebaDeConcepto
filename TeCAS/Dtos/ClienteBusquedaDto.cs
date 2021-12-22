using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeCAS.Dtos
{
    public class ClienteBusquedaDto
    {        
        [Display(Name = "Nombre")]
        [MaxLength(50)]
        public string Nombre { get; set; }
             
        [Display(Name = "Paterno")]
        [MaxLength(50)]
        public string Paterno { get; set; }

        [Display(Name = "Número de identificación")]
        [MaxLength(20)]
        public string NumeroDeIdentificacion { get; set; }

        public List<ClienteDto> ListaDeClientes { get; set; }
    }
}
