using System;

namespace TeCAS.Dtos
{
    public class BasePaginadoDto
    {
        public int PaginaActual { get; set; }
        public int NumeroDeRegistrosPorPagina { get; set; }
        public int TotalDeRegistros { get; set; }

        public int NumeroDePagina
        {
            get
            {
                return (int)Math.Ceiling((double)TotalDeRegistros / NumeroDeRegistrosPorPagina);
            }
        }
    }
}
