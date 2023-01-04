using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype__Patrón_creacional_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaAHImpl cuentaAhorro = new CuentaAHImpl();
            cuentaAhorro.setMonto(200);
            CuentaAHImpl cuentaClonada = (CuentaAHImpl)cuentaAhorro.Clonar();

            if (cuentaClonada != null)
            {
                //Aca lo que vemos es que tiene los mismos 
                //valores que la clase cuentaAhorro.
                Console.WriteLine(cuentaClonada.toString()); 
            }
            //Aca vemos que cuentaClonada y cuentaAhorro
            //no ocupan el mismo espacio en memoria.
            Console.WriteLine(cuentaClonada == cuentaAhorro);
            Console.ReadKey();
        }
    }
}
