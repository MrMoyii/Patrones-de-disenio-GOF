using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy__Patrón_estructural_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Proxy hace de intermediario por nosotros
            //En este caso es un intermediario de cuenta
            //el cual nos permite operar con los metodos definidos
            //en la clase implementacion.



            Cuenta c = new Cuenta(1,"Moyano", 1000);

            ICuenta cuentaProxy = new CuentaProxy(new CuentaBancoAImpl());
            cuentaProxy.mostrarSaldo(c);
            c = cuentaProxy.depositarDinero(c, 50);
            c = cuentaProxy.retirarDinero(c, 100);
            cuentaProxy.mostrarSaldo(c);

            Console.ReadKey();
        }
    }
}
