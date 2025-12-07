using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viajes.Controller
{
    public class ViajeDto
    {
        public int IdViaje { get; set; }
        public string Destino { get; set; }
        public decimal Precio { get; set; }
        public int PlazasDisponibles { get; set; }
        public List<ReservaDto> Reservas { get; set; }

    }
}
