using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator__Patrón_estructural_
{
    internal class Cuenta
    {
        private int id;
        private string cliente;

        public Cuenta()
        {

        }

        public Cuenta(int id, string cliente)
        {
            this.id = id;
            this.cliente = cliente;
        }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getCliente()
        {
            return cliente;
        }
        public void setCliente(string cliente)
        {
            this.cliente = cliente;
        }
    }
}
