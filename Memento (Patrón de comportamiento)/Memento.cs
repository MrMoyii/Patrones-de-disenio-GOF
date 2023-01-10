using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento__Patrón_de_comportamiento_
{
    internal class Memento
    {
        private Juego estado;
        public Memento(Juego estado)
        {
            this.estado = estado;
        }
        public Juego getEstado() { return estado; }
    }
}
