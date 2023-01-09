using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory__ej_con_gatos___Patrón_creacional_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGatoCompañero gatoCompañero = new FabricaDeGatos().Crear();

            gatoCompañero.jugar();
            gatoCompañero.alimentar();

            Console.ReadKey();
        }
    }
}
