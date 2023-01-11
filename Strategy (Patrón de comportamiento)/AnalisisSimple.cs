using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy__Patrón_de_comportamiento_
{
    internal abstract class AnalisisSimple : IEstrategia
    {
        public void analizar()
        {
            Iniciar();
            SaltarZip();
            Detener();
        }

        public abstract void Iniciar();
        public abstract void SaltarZip();
        public abstract void Detener();
    }
}
