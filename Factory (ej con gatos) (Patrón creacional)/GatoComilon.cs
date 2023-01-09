using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory__ej_con_gatos___Patrón_creacional_
{
    internal class GatoComilon : IGatoCompañero
    {
        public void alimentar()
        {
            Console.WriteLine("ñam ñam ñam");
        }

        public void jugar()
        {
            Console.WriteLine("miau miau (tengo hambre)");
        }
    }
}
