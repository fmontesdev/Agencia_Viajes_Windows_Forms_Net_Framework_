using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // Para utilizar metodos asincrónicos de Entity Framework

namespace Viajes.Model
{
    public class ViajesRepositorio
    {
        // Instancia del contexto de la base de datos
        private readonly AgenciaPacoEntities _context = new AgenciaPacoEntities();

        // Obtiene todos los viajes
        public async Task<List<Viajes>> SeleccionarAsync()
        {
            return await _context.Viajes.Include("Reservas").ToListAsync();
        }

        // Crea un nuevo viaje
        public async Task CrearAsync(Viajes viaje)
        {
            _context.Viajes.Add(viaje);
            await _context.SaveChangesAsync();
        }

        // Guarda los cambios realizados en un viaje
        public async Task GuardarAsync()
        {
            await _context.SaveChangesAsync();
        }

        // Elimina un viaje
        public async Task EliminarAsync(Viajes viaje)
        {
            _context.Viajes.Remove(viaje);
            await _context.SaveChangesAsync();
        }

        // Inicia una transacción en base de datos
        public DbContextTransaction IniciarTransaccion()
        {
            return _context.Database.BeginTransaction();
        }

        // Obtiene el contexto actual (para operaciones dentro de transacciones)
        public AgenciaPacoEntities ObtenerContexto()
        {
            return _context;
        }
    }
}
