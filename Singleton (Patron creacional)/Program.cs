using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton__Patron_creacional_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conexion c1 = new Conexion(); No se me permite porque el ctor es privado para no crear instancias de esta clase.

            //Esta es la unica forma de obtener una instancia de la clase y a partir de ella los clientes se conectan.
            Conexion c = Conexion.getInstance();

            c.conectar();
            c.desconectar();

            Console.ReadKey();
        }
    }
}
