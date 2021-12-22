﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeCAS.Dtos;
using TeCAS.Models;

namespace TeCAS.BussinesLayer
{
    public class ClienteBl
    {
        internal static async Task<int> AgregarAsync(ClienteDto clienteDto)
        {
            try
            {
                Cliente cliente;

                cliente = new Cliente
                {
                    Rfc = clienteDto.Rfc,
                    Paterno = clienteDto.Paterno,
                    NumeroDeIdentificacion = clienteDto.NumeroDeIdentificacion,
                    Nombre = clienteDto.Nombre,
                    Materno = clienteDto.Materno,
                    FechaDeRegistro = DateTime.Now,
                    UsuarioId = clienteDto.UsuarioId
                };
                using (var db = new AppDbContext())
                {
                    db.Cliente.Add(cliente);
                    await db.SaveChangesAsync();
                }

                return cliente.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal static async Task<ListaDeClientesDto> Obtener(BusquedaDeClienteDto busquedeDeCliente)
        {
            try
            {
                ListaDeClientesDto listaDeClientes;
                List<Cliente> clientes;
                int totalDeRegistros;


                using (var db = new AppDbContext())
                {
                    clientes = await db.Cliente
                    .OrderBy(x => x.Id)
                        .Skip((busquedeDeCliente.PaginaActual - 1) * busquedeDeCliente.NumeroDeRegistrosPorPagina)
                        .Take(busquedeDeCliente.NumeroDeRegistrosPorPagina)
                        .ToListAsync();

                    totalDeRegistros = db.Cliente
                        .Count();
                }

                listaDeClientes = new ListaDeClientesDto
                {
                    BusquedeDeCliente = busquedeDeCliente,
                    ListaDeClientes = Obtener(clientes)
                };

                return listaDeClientes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static List<ClienteDto> Obtener(List<Cliente> clientes)
        {
            List<ClienteDto> clienteDtos;

            clienteDtos = new List<ClienteDto>();
            clientes.ForEach(cliente =>
            {
                ClienteDto clienteDto;

                clienteDto = Obtener(cliente);

                clienteDtos.Add(clienteDto);
            });

            return clienteDtos;
        }

        private static ClienteDto Obtener(Cliente cliente)
        {
            return new ClienteDto
            {
                Id = cliente.Id,
                Materno = cliente.Materno,
                Nombre = cliente.Nombre,
                NumeroDeIdentificacion = cliente.NumeroDeIdentificacion,
                Paterno = cliente.Paterno,
                Rfc = cliente.Rfc
            };
        }

        public static async Task<ClienteDto> Obtener(int clienteId)
        {
            try
            {
                ClienteDto clienteDto;
                Cliente cliente;

                using (var db = new AppDbContext())
                {
                    cliente = await db.Cliente.FirstAsync(x => x.Id == clienteId);
                }
                if (cliente is null)
                    clienteDto = null;
                else
                    clienteDto = Obtener(cliente);

                return clienteDto;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}