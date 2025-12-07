using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viajes.Model;

namespace Viajes.Controller
{
    public class ViajeMapper
    {
        public static ViajeDto ToDto(Viajes.Model.Viajes entity)
        {
            return new ViajeDto
            {
                IdViaje = entity.IdViaje,
                Destino = entity.Destino,
                Precio = entity.Precio,
                PlazasDisponibles = entity.PlazasDisponibles,
                Reservas = new List<ReservaDto>()
            };
        }

        public static ViajeDto ToDtoConReservas(Viajes.Model.Viajes entity)
        {
            return new ViajeDto
            {
                IdViaje = entity.IdViaje,
                Destino = entity.Destino,
                Precio = entity.Precio,
                PlazasDisponibles = entity.PlazasDisponibles,
                Reservas = entity.Reservas != null
                    ? ReservaMapper.ToDtoList(entity.Reservas.ToList())
                    : new List<ReservaDto>()
            };
        }

        public static List<ViajeDto> ToDtoList(List<Viajes.Model.Viajes> entities)
        {
            return entities.Select(e => ToDto(e)).ToList();
        }

        public static List<ViajeDto> ToDtoListConReservas(List<Viajes.Model.Viajes> entities)
        {
            return entities.Select(e => ToDtoConReservas(e)).ToList();
        }
    }
}
