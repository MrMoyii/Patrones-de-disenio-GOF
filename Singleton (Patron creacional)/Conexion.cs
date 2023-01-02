using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton__Patron_creacional_
{
    internal class Conexion
    {
        //Declaración
        private static Conexion instancia;
        //priavte static Conexion instancia = new Conexion();

        //Para evitar instancia mediante operador "new".
        private Conexion()
        {

        }

        //Para obtener la insntacia unicamente por este metodo
        //Notese la palabra reservada "static" hace posible el acceso mediante Clase.metodo
        public static Conexion getInstance() 
        {
            if (instancia == null) //si no se instancio la clase
            {
                instancia = new Conexion(); //, pues se isntancia
            }
            // y la retorna. //Sino significa que ya se instancio y simplemente retorna esa instancia.
            return instancia;
        }


        //Metodo de prueba
        public void conectar()
        {
            Console.WriteLine("Me conecté a la BD");
        }
        //Metodo de prueba
        public void desconectar()
        {
            Console.WriteLine("Me desconecté de la BD");
        }
    }
}
