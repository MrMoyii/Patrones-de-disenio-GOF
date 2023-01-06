using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade__Patrón_estructural_
{
    internal class HotelAPI
    {
        public void BuscarVuelos(string fechaEntrada, string fechaSalida, string origen, string destino)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Hoteles encontrados");
            Console.WriteLine("Entrada: " + fechaEntrada + ". Salida: " + fechaSalida);
            Console.WriteLine("Hotel A");
            Console.WriteLine("Hotel B");
            Console.WriteLine("Hotel C");
            Console.WriteLine("===================================");
        }
    }
}
