using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator__Patrón_estructural_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta c = new Cuenta(1, "Moyano");
            
            //A la cuenta
            ICuentaBancaria cuenta = new CuentaAhorro();
            //La paso al decorador para agregarle la nueva funcionalidad.
            ICuentaBancaria cuentaBlindada = new BlindajeDecorador(cuenta);

            //cuenta.abrirCuenta(c);
            cuentaBlindada.abrirCuenta(c);

            Console.ReadKey();
        }
    }
}
