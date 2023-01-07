using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator__Patrón_estructural_
{
    internal class BlindajeDecorador : CuentaDecorador
    {
        public BlindajeDecorador(ICuentaBancaria cuentaDecorada) : base(cuentaDecorada) { }

        new public void abrirCuenta(Cuenta c)
        {
            cuentaDecorada.abrirCuenta(c);
            agregarBlindaje(c); //Aca agrego una funcionalidad adicional
        }

        //Osea esta funcionalidad
        public void agregarBlindaje(Cuenta c)
        {
            Console.WriteLine("Se agregó blindaje a la cuenta del cliente" + c.getCliente());
        }
    }
}
