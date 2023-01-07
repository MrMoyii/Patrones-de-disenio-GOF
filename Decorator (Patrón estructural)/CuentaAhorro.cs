using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator__Patrón_estructural_
{
    internal class CuentaAhorro : ICuentaBancaria
    {
        public void abrirCuenta(Cuenta c)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Se abrio una cuenta de ahorros");
            Console.WriteLine("Cliente: " + c.getCliente());
        }
    }
}
