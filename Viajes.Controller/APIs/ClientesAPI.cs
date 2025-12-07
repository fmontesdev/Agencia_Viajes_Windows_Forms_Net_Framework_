using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viajes.Model;

namespace Viajes.Controller
{
    public class ClientesAPI
    {
        // Instancia del repositorio de Clientes
        private readonly ClientesRepositorio _repo = new ClientesRepositorio();

        //Obtiene todos los clientes
        public async Task<List<ClienteDto>> ObtenerClientesAsync()
        {
            var clientes = (await _repo.SeleccionarAsync());
            return ClienteMapper.ToDtoListConReservas(clientes.ToList());
        }

        // Crea un nuevo cliente con los datos proporcionados
        public async Task CrearClienteAsync(ClienteDto dto)
        {
            Clientes entity = new Clientes
            {
                Nombre = dto.Nombre,
                Apellidos = dto.Apellidos,
                Email = dto.Email
            };
            await _repo.CrearAsync(entity);
        }

        // Actualiza los datos de un cliente existente
        public async Task ActualizarClienteAsync(ClienteDto dto)
        {
            // Busca el cliente por su ID
            Clientes entity = (await _repo.SeleccionarAsync()).FirstOrDefault(c => c.IdCliente == dto.IdCliente);
            // Si no lo encuentra, lanza una excepción
            if (entity == null) throw new Exception("El cliente especificado no existe");

            // Actualiza los datos del cliente
            entity.Nombre = dto.Nombre;
            entity.Apellidos = dto.Apellidos;
            entity.Email = dto.Email;

            await _repo.GuardarAsync();
        }

        // Elimina un cliente por su ID
        public async Task EliminarClienteAsync(int idCliente)
        {
            using (var transaccion = _repo.IniciarTransaccion())
            {
                try
                {
                    // Obtiene el contexto compartido para la transacción
                    var context = _repo.ObtenerContexto();

                    // Busca el cliente por su ID, si no lo encuentra lanza una excepción
                    Clientes cliente = await context.Clientes.FirstOrDefaultAsync(c => c.IdCliente == idCliente);
                    if (cliente == null) throw new Exception("El cliente especificado no existe");

                    // Busca reservas asociadas al cliente
                    List<Reservas> reservas = cliente.Reservas.ToList();

                    // Verifica si hay reservas activas, si es así lanza una excepción
                    List<Reservas> reservasActivas = reservas.Where(r => r.FechaReserva >= DateTime.Now.Date).ToList();
                    if (reservasActivas.Count > 0) throw new Exception("No se puede eliminar el cliente porque tiene reservas activas");

                    // Si no hay reservas activas, elimina las reservas históricas asociadas al cliente
                    context.Reservas.RemoveRange(reservas);

                    // Elimina el cliente
                    context.Clientes.Remove(cliente);

                    // Guarda los cambios
                    await context.SaveChangesAsync();

                    // Confirma la transacción si todo fue exitoso
                    transaccion.Commit();
                }
                catch (Exception)
                {
                    // Si ocurre un error, revierte la transacción
                    transaccion.Rollback();
                    throw;
                }
            }
        }
    }
}
