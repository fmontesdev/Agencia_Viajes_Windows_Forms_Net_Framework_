using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viajes.Controller
{
    public class ReservaDto
    {
        public int IdReserva { get; set; }
        public int IdCliente { get; set; }
        public int IdViaje { get; set; }
        public DateTime FechaReserva { get; set; }
        public ClienteDto Cliente { get; set; }
        public ViajeDto Viaje { get; set; }

        // Propiedades calculadas para el DataGridView
        public string ClienteNombreCompleto => Cliente.NombreCompleto;
        public string ViajeDestino => Viaje.Destino;
        public decimal ViajePrecio => Viaje.Precio;
    }
}
