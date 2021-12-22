using System.Collections.Generic;

namespace TeCAS.Dtos
{
    public class ListaDeClientesDto
    {
        public BusquedaDeClienteDto BusquedeDeCliente { get; set; }
        public List<ClienteDto> ListaDeClientes { get; set; }
    }
}
