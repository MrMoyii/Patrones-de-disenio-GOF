using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade__Patrón_estructural_
{
    internal class CheckFacade
    {
        private AvionAPI avionAPI;
        private HotelAPI hotelAPI;

        public CheckFacade()
        {
            avionAPI= new AvionAPI();
            hotelAPI= new HotelAPI();
        }

        public void buscar(string fechaIda, string fechaVuelta, string origen, string destino)
        {
            avionAPI.BuscarVuelos(fechaIda,fechaVuelta,origen,destino);
            hotelAPI.BuscarHoteles(fechaIda,fechaVuelta,origen,destino);
        }
    }
}
