using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comand__Patrón_de_comportamiento_
{
    internal class Invoker
    {
        private List<IOperacion> operaciones= new List<IOperacion>();

        public void recibirOperacion(IOperacion operacion)
        {
            this.operaciones.Add(operacion);
        }
        public void realizarOperacion()
        {
            this.operaciones.ForEach(operacion => { operacion.execute(); });
            this.operaciones.Clear();
        }
    }
}
