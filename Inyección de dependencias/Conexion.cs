using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inyección_de_dependencias
{
    internal class Conexion
    {
        private string usuario;
        private string clave;
        private string host;

        public Conexion(string usuario, string clave, string host)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.host = host;
        }
    }
}
