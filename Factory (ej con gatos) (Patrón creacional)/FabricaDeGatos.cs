using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory__ej_con_gatos___Patrón_creacional_
{
    internal class FabricaDeGatos
    {
        public IGatoCompañero Crear()
        {
            /*Aca puedo descomentar el codigo y obtener otro tipo de gato*/
            //return new GatoJugueton();

            return new GatoComilon();
        }
    }
}
