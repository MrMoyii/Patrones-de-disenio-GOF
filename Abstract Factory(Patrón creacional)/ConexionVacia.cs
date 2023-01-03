using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory__Patrón_creacional_
{
    internal class ConexionVacia : IConexion
    {
        public void Conectar()
        {
            Console.WriteLine("NO SE ESPECIFICÓ PROVEEDOR");
        }

        public void Desconectar()
        {
            Console.WriteLine("NO SE ESPECIFICÓ PROVEEDOR");
        }
    }
}
