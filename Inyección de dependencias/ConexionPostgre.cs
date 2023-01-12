using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyección_de_dependencias
{
    internal class ConexionPostgre : IConexion
    {
        private string usuario;
        private string clave;
        private string host;

        public ConexionPostgre(string usuario, string clave, string host)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.host = host;
        }

        public void conectar()
        {
            Console.WriteLine("Conectando a MySQL");
        }
    }
}
