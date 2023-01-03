using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory__Patrón_creacional_
{
    internal class ConexionPostgreSQL : IConexion
    {
        private string host;
        private string puerto;
        private string usuario;
        private string contraseña;

        public ConexionPostgreSQL()
        {
            this.host = "localhost";
            this.puerto = "222";
            this.usuario = "root";
            this.contraseña = "123";
        }

        public void Conectar()
        {
            Console.WriteLine("Se conecto a PostgreSQL");
        }

        public void Desconectar()
        {
            Console.WriteLine("Se desconecto de PostgreSQL");
        }
    }
}
