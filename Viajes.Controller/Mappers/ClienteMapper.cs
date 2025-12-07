using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viajes.Model;

namespace Viajes.Controller
{
    public class ClienteMapper
    {
        public static ClienteDto ToDto(Clientes entity)
        {
            return new ClienteDto
            {
                IdCliente = entity.IdCliente,
                Nombre = entity.Nombre,
                Apellidos = entity.Apellidos,
                Email = entity.Email,
                Reservas = new List<ReservaDto>()
            };
        }

        public static ClienteDto ToDtoConReservas(Clientes entity)
        {
            return new ClienteDto
            {
                IdCliente = entity.IdCliente,
                Nombre = entity.Nombre,
                Apellidos = entity.Apellidos,
                Email = entity.Email,
                Reservas = entity.Reservas != null
                    ? ReservaMapper.ToDtoList(entity.Reservas.ToList())
                    : new List<ReservaDto>()
            };
        }

        public static List<ClienteDto> ToDtoList(List<Clientes> entities)
        {
            return entities.Select(e => ToDto(e)).ToList();
        }

        public static List<ClienteDto> ToDtoListConReservas(List<Clientes> entities)
        {
            return entities.Select(e => ToDtoConReservas(e)).ToList();
        }
    }
}
