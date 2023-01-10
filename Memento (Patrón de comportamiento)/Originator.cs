using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento__Patrón_de_comportamiento_
{
    internal class Originator
    {
        private Juego estado;

        public void setEstado(Juego estado)
        {
            this.estado = estado;
        }
        public Juego getEstado() { return estado; }

        public Memento guardar()
        {
            return new Memento(estado);
        }
        public void restaurar(Memento m)
        {
            this.estado = m.getEstado();
        }
    }
}
