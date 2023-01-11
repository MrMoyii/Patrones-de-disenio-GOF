using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy__Patrón_de_comportamiento_
{
    internal abstract class AnalisisAvanzado : IEstrategia
    {
        public void analizar()
        {
            Iniciar();
            AnalizarMemoria();
            AnalizarKeyLoggers();
            AnalizarRootKits();
            DescomprimirZip();
            Detener();
        }

        public abstract void Iniciar();
        public abstract void AnalizarMemoria();
        public abstract void AnalizarKeyLoggers();
        public abstract void AnalizarRootKits();
        public abstract void DescomprimirZip();
        public abstract void Detener();
    }
}
