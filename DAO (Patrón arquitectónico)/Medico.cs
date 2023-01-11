using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO__Patrón_arquitectónico_
{
    internal class Medico
    {
        private int id;
        private string nombres;

        public int getID()
        {
            return id;
        }
        public void setID(int id)
        {
            this.id = id;
        }
        public string getNombres()
        {
            return nombres;
        }
        public void setNombres(string nombres)
        {
            this.nombres = nombres;
        }
    }
}
