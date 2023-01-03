using Abstract_Factory_Patrón_creacional_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Factory__Patrón_creacional_
{
    internal class ConexionRESTFabrica : FabricaAbstracta
    {
        public IConexion getBD(string motor)
        {
            return null;
        }

        public IConexionREST getREST(string area)
        {
            if (area == null)
                return new ConexionRESTNoArea();

            if (area.Equals("COMPRAS"))
                return new ConexionRESTCompras();
            else if (area.Equals("VENTAS"))
                return new ConexionRESTVentas();

            return new ConexionRESTNoArea();
        }
    }
}
