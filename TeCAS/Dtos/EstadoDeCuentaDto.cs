using System.Collections.Generic;

namespace TeCAS.Dtos
{
    public class EstadoDeCuentaDto
    {
        public ClienteDto Cliente { get; set; }
        public CuentaDeAhorroDto CuentaDeAhorro { get; set; }

        public List<CuentaDeAhorroDetalleDto> ListaDeTransacciones { get; set; }
    }
}
