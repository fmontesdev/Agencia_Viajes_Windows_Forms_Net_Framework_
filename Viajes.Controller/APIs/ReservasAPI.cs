using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viajes.Model;

namespace Viajes.Controller
{
    public class ReservasAPI
    {
        // Instancia del repositorio de Reservas
        private readonly ReservasRepositorio _repo = new ReservasRepositorio();

        //Obtiene todos las reservas
        public async Task<List<ReservaDto>> ObtenerReservasAsync()
        {
            var reservas = (await _repo.SeleccionarAsync());
            return ReservaMapper.ToDtoListConClientesYViajes(reservas.ToList());
        }

        // Crea una nueva reserva con los datos proporcionados
        public async Task CrearReservaAsync(ReservaDto dto)
        {
            using (var transaccion = _repo.IniciarTransaccion())
            {
                try
                {
                    // Obtiene el contexto compartido para la transacción
                    var context = _repo.ObtenerContexto();

                    // Verifica que el cliente exista, si no lanza una excepción
                    Clientes cliente = await context.Clientes.FirstOrDefaultAsync(c => c.IdCliente == dto.IdCliente);
                    if (cliente == null) throw new Exception("El cliente especificado no existe");

                    // Verifica que el viaje exista, si no lanza una excepción
                    Viajes.Model.Viajes viaje = await context.Viajes.FirstOrDefaultAsync(v => v.IdViaje == dto.IdViaje);
                    if (viaje == null) throw new Exception("El viaje especificado no existe");

                    // Verifica que haya plazas disponibles para el viaje
                    if (viaje.PlazasDisponibles <= 0) throw new Exception("No hay plazas disponibles para el viaje seleccionado");

                    // Crea la nueva reserva
                    Reservas entity = new Reservas
                    {
                        IdCliente = dto.IdCliente,
                        IdViaje = dto.IdViaje,
                        FechaReserva = dto.FechaReserva
                    };
                    context.Reservas.Add(entity);

                    // Reduce en 1 las plazas disponibles del viaje
                    viaje.PlazasDisponibles -= 1;

                    // Guarda todos los cambios en una sola operación
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

        // Actualiza la fecha de una reserva existente
        public async Task ActualizarReservaAsync(ReservaDto dto)
        {
            // Busca la reserva por su ID
            Reservas entity = (await _repo.SeleccionarAsync()).FirstOrDefault(r => r.IdReserva == dto.IdReserva);
            // Si no lo encuentra, lanza una excepción
            if (entity == null) throw new Exception("La reserva especificada no existe");

            // Actualiza la fecha de la reserva
            entity.FechaReserva = dto.FechaReserva;

            await _repo.GuardarAsync();
        }

        // Elimina una reserva por su ID
        public async Task EliminarReservaAsync(int idReserva)
        {
            using (var transaccion = _repo.IniciarTransaccion())
            {
                try
                {
                    // Obtiene el contexto compartido para la transacción
                    var context = _repo.ObtenerContexto();

                    // Busca la reserva por su ID, si no la encuentra lanza una excepción
                    Reservas reserva = await context.Reservas.FirstOrDefaultAsync(r => r.IdReserva == idReserva);
                    if (reserva == null) throw new Exception("La reserva especificada no existe");

                    // Recupera el viaje asociado a la reserva eliminada
                    Viajes.Model.Viajes viaje = await context.Viajes.FirstOrDefaultAsync(v => v.IdViaje == reserva.IdViaje);

                    if (viaje != null)
                    {
                        // Incrementa en 1 las plazas disponibles del viaje
                        viaje.PlazasDisponibles += 1;
                    }
                    else
                    {
                        throw new Exception("El viaje asociado a la reserva no existe");
                    }

                    // Elimina la reserva
                    context.Reservas.Remove(reserva);

                    // Guarda todos los cambios en una sola operación
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
