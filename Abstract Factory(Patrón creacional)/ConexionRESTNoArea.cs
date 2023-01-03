using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Patrón_creacional_
{
    internal class ConexionRESTNoArea : IConexionREST
    {
        public void leerURL(string url)
        {
            Console.WriteLine("Area no elegida.");
        }
    }
}
