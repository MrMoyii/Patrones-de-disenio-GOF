using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade__Patrón_estructural_
{
    internal class HotelAPI
    {
        public void BuscarVuelos(string fechaIda, string fechaVuelta, string origen, string destino)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Vuelos encontrads para " + destino + " desde " + origen);
            Console.WriteLine("Fecha Ida: " + fechaIda + ". Fecha Vuelta: " + fechaVuelta);
            Console.WriteLine("===================================");
        }
    }
}
