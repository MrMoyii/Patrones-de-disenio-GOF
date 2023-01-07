using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator__Patrón_estructural_
{
    internal abstract class CuentaDecorador : ICuentaBancaria
    {
        protected ICuentaBancaria cuentaDecorada;

        public CuentaDecorador(ICuentaBancaria cuentaDecorada)
        {
            this.cuentaDecorada = cuentaDecorada;
        }

        public void abrirCuenta(Cuenta c)
        {
            this.cuentaDecorada.abrirCuenta(c);
        }
    }
}
