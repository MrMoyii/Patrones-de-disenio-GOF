using Factory__Patrón_creacional_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Patrón_creacional_
{
    internal class FabricaProductor
    {
        public static FabricaAbstracta getFactory(String tipoFabrica)
        {

            if (tipoFabrica.Equals("BD"))
            {
                return new ConexionFabrica();

            }
            else if (tipoFabrica.Equals("REST"))
            {
                return new ConexionRESTFabrica();
            }

            return null;
        }
    }
}
