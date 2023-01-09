using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy__Patrón_estructural_
{
    internal class CuentaProxy : ICuenta
    {
        private ICuenta cuentaReal;

        public CuentaProxy(ICuenta cuentaReal)
        {
            this.cuentaReal = cuentaReal;
        }

        public Cuenta retirarDinero(Cuenta cuenta, double monto)
        {
            if (cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAImpl();
                return cuentaReal.retirarDinero(cuenta, monto);
            }
            else
            {
                return cuentaReal.retirarDinero(cuenta, monto);
            }
        }
        public Cuenta depositarDinero(Cuenta cuenta, double monto)
        {
            if (cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAImpl();
                return cuentaReal.depositarDinero(cuenta, monto);
            }
            else
            {
                return cuentaReal.depositarDinero(cuenta, monto);
            }
        }

        public void mostrarSaldo(Cuenta cuenta)
        {
            if (cuentaReal == null)
            {
                cuentaReal = new CuentaBancoAImpl();
                cuentaReal.mostrarSaldo(cuenta);
            }
            else
            {
                cuentaReal.mostrarSaldo(cuenta);
            }
        }

    }
}
