using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento__Patrón_de_comportamiento_
{
    internal class Juego
    {
        private string nombre;
        private int checkpoint;

        public int getCheckpoint()
        {
            return checkpoint;
        }
        public void setCheckpoint(int checkpoint)
        {
            this.checkpoint = checkpoint;
        }

        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string toString()
        {
            return "Juego [nombre=" + nombre + ", checkpoint= " + checkpoint + "]";
        }
    }
}
