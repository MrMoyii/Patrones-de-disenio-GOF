using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy__Patrón_de_comportamiento_
{
    internal class Contexto
    {
        private IEstrategia estrategia;
        public Contexto(IEstrategia estrategia)
        {
            this.estrategia = estrategia;
        }

        public void Ejecutar()
        {
            this.estrategia.analizar();
        }
    }
}
