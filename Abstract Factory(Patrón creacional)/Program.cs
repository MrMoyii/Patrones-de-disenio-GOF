using Factory__Patrón_creacional_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Patrón_creacional_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FabricaAbstracta fa = FabricaProductor.getFactory("BD");
            IConexion cxBD1 = fa.getBD("MYSQL");

            cxBD1.Conectar();

            FabricaAbstracta faREST = FabricaProductor.getFactory("REST");
            IConexionREST cxRS1 = faREST.getREST("COMPRAS");

            cxRS1.leerURL("https://www.youtube.com/");
        }
    }
}
