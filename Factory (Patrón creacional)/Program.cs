using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory__Patrón_creacional_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConexionFabrica fabrica= new ConexionFabrica();

            IConexion cx1 = fabrica.GetConexion("ORACLE");
            cx1.Conectar();
            cx1.Desconectar();

            IConexion cx2 = fabrica.GetConexion("MYSQL");
            cx2.Conectar();
            cx2.Desconectar();

            IConexion cx3 = fabrica.GetConexion("H2");
            cx3.Conectar();
            cx3.Desconectar();

            Console.ReadKey();
        }
    }
}
