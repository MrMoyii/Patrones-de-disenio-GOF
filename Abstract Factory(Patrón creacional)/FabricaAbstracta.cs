using Factory__Patrón_creacional_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Patrón_creacional_
{
    internal interface FabricaAbstracta
    {
        IConexion getBD(string motor);
        IConexionREST getREST(string area);
    }
}
