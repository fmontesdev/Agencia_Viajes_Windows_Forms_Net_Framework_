using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viajes.Controller
{
    public class ClienteDto
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public List<ReservaDto> Reservas { get; set; }

        // Propiedad calculada para mostrar el nombre completo
        public string NombreCompleto => $"{Nombre} {Apellidos}";
    }
}
