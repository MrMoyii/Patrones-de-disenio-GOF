using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy__Patrón_estructural_
{
    internal interface ICuenta
    {
        Cuenta retirarDinero(Cuenta cuenta, double monto);
        Cuenta depositarDinero(Cuenta cuenta, double monto);
        void mostrarSaldo(Cuenta cuenta);
    }
}
