using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // Para utilizar metodos asincrónicos de Entity Framework

namespace Viajes.Model
{
    public class ClientesRepositorio
    {
        // Instancia del contexto de la base de datos
        private readonly AgenciaPacoEntities _context = new AgenciaPacoEntities();

        //Obtiene todos los clientes
        public async Task<List<Clientes>> SeleccionarAsync()
        {
            return await _context.Clientes.Include("Reservas").ToListAsync();
        }

        // Crea un nuevo cliente
        public async Task CrearAsync(Clientes entity)
        {
            _context.Clientes.Add(entity);
            await _context.SaveChangesAsync();
        }

        // Guarda los cambios realizados en un cliente
        public async Task GuardarAsync()
        {
            await _context.SaveChangesAsync();
        }

        // Elimina un cliente
        public async Task EliminarAsync(Clientes entity)
        {
            _context.Clientes.Remove(entity);
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
