using DAO__Patrón_arquitectónico_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyección_de_dependencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conexion cx1 = new Conexion("Moyi", "7482", "localhost");

            Conexion cx2 = new Conexion("Moyi", "7482", "192.168.1.1");

            PersonaDAO dao = new PersonaDAOImpl(cx1);

            dao.listarTodos();

            Console.ReadKey();
        }
    }
}
