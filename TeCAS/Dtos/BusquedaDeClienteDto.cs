using System.ComponentModel.DataAnnotations;

namespace TeCAS.Dtos
{
    public class BusquedaDeClienteDto: BasePaginadoDto
    {
        [Display(Name = "Nombre")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Display(Name = "Número de identificación")]
        [MaxLength(20)]
        public string NumeroDeIdentificacion { get; set; }

        public BusquedaDeClienteDto()
        {
            this.PaginaActual = 1;
            this.NumeroDeRegistrosPorPagina = 10;
        }
    }
}
