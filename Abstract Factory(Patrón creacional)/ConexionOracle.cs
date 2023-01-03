using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory__Patrón_creacional_
{
    internal class ConexionOracle : IConexion
    {
        private string host;
        private string puerto;
        private string usuario;
        private string contraseña;

        public ConexionOracle()
        {
            this.host = "localhost";
            this.puerto = "222";
            this.usuario = "root";
            this.contraseña = "123";
        }

        public void Conectar()
        {
            Console.WriteLine("Se conecto a Oracle");
        }

        public void Desconectar()
        {
            Console.WriteLine("Se desconecto de Oracle");
        }
    }
}
