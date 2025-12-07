using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // Para utilizar metodos asincrónicos de Entity Framework

namespace Viajes.Model
{
    public class ReservasRepositorio
    {
        // Instancia del contexto de la base de datos
        private readonly AgenciaPacoEntities _context = new AgenciaPacoEntities();

        // Obtiene todas las reservas
        public async Task<List<Reservas>> SeleccionarAsync()
        {
            return await _context.Reservas.Include("Clientes").Include("Viajes").ToListAsync();
        }

        // Crea un nueva reserva
        public async Task CrearAsync(Reservas reserva)
        {
            _context.Reservas.Add(reserva);
            await _context.SaveChangesAsync();
        }

        // Guarda los cambios realizados en una reserva
        public async Task GuardarAsync()
        {
            await _context.SaveChangesAsync();
        }

        // Elimina una reserva
        public async Task EliminarAsync(Reservas reserva)
        {
            _context.Reservas.Remove(reserva);
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
