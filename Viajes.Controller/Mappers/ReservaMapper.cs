using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viajes.Model;

namespace Viajes.Controller
{
    public class ReservaMapper
    {
        public static ReservaDto ToDto(Reservas entity)
        {
            return new ReservaDto
            {
                IdReserva = entity.IdReserva,
                IdCliente = entity.IdCliente,
                IdViaje = entity.IdViaje,
                FechaReserva = entity.FechaReserva,
                Cliente = null,
                Viaje = null
            };
        }

        public static ReservaDto ToDtoConClientesYViajes(Reservas entity)
        {
            return new ReservaDto
            {
                IdReserva = entity.IdReserva,
                IdCliente = entity.IdCliente,
                IdViaje = entity.IdViaje,
                FechaReserva = entity.FechaReserva,
                Cliente = ClienteMapper.ToDto(entity.Clientes),
                Viaje = ViajeMapper.ToDto(entity.Viajes)
            };
        }

        public static List<ReservaDto> ToDtoList(List<Reservas> entities)
        {
            return entities.Select(e => ToDto(e)).ToList();
        }

        public static List<ReservaDto> ToDtoListConClientesYViajes(List<Reservas> entities)
        {
            return entities.Select(e => ToDtoConClientesYViajes(e)).ToList();
        }
    }
}
