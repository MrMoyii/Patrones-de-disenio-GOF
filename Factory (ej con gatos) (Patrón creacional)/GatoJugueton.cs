using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory__ej_con_gatos___Patrón_creacional_
{
    internal class GatoJugueton : IGatoCompañero
    {
        public void alimentar()
        {
            Console.WriteLine("(ignora la comida)");
        }

        public void jugar()
        {
            Console.WriteLine("miau miau miau");
        }
    }
}
