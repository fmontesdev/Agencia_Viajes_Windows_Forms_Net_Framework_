using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viajes.Model;

namespace Viajes.Controller
{
    public class ViajesAPI
    {
        // Instancia del repositorio de Viajes
        private readonly ViajesRepositorio _repo = new ViajesRepositorio();

        //Obtiene todos los viajes
        public async Task<List<ViajeDto>> ObtenerViajesAsync()
        {
            var viajes = (await _repo.SeleccionarAsync());
            return ViajeMapper.ToDtoListConReservas(viajes.ToList());
        }

        // Crea un nuevo viaje con los datos proporcionados
        public async Task CrearViajeAsync(ViajeDto dto)
        {
            Viajes.Model.Viajes entity = new Viajes.Model.Viajes
            {
                Destino = dto.Destino,
                Precio = dto.Precio,
                PlazasDisponibles = dto.PlazasDisponibles
            };
            await _repo.CrearAsync(entity);
        }

        // Actualiza los datos de un viaje existente
        public async Task ActualizarViajeAsync(ViajeDto dto)
        {
            // Busca el viaje por su ID
            Viajes.Model.Viajes entity = (await _repo.SeleccionarAsync()).FirstOrDefault(v => v.IdViaje == dto.IdViaje);
            // Si no lo encuentra, lanza una excepción
            if (entity == null) throw new Exception("El viaje especificado no existe");

            // Actualiza los datos del viaje
            entity.Destino = dto.Destino;
            entity.Precio = dto.Precio;
            entity.PlazasDisponibles = dto.PlazasDisponibles;

            await _repo.GuardarAsync();
        }

        // Elimina un viaje por su ID
        public async Task EliminarViajeAsync(int idViaje)
        {
            using (var transaccion = _repo.IniciarTransaccion())
            {
                try
                {
                    // Obtiene el contexto compartido para la transacción
                    var context = _repo.ObtenerContexto();

                    // Busca el viaje por su ID, si no lo encuentra lanza una excepción
                    Viajes.Model.Viajes viaje = await context.Viajes.FirstOrDefaultAsync(v => v.IdViaje == idViaje);
                    if (viaje == null) throw new Exception("El viaje especificado no existe");

                    // Busca reservas asociadas al viaje
                    List<Reservas> reservas = viaje.Reservas.ToList();

                    // Verifica si hay reservas activas, si es así lanza una excepción
                    List<Reservas> reservasActivas = reservas.Where(r => r.FechaReserva >= DateTime.Now.Date).ToList();
                    if (reservasActivas.Count > 0) throw new Exception("No se puede eliminar el viaje porque tiene reservas activas");

                    // Si no hay reservas activas, elimina las reservas históricas asociadas al viaje
                    context.Reservas.RemoveRange(reservas);

                    // Elimina el viaje
                    context.Viajes.Remove(viaje);

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
