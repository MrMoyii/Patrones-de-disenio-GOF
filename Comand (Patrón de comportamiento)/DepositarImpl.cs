using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comand__Patrón_de_comportamiento_
{
    internal class DepositarImpl : IOperacion
    {
        private Cuenta cuenta;
        private double monto;

        public DepositarImpl(Cuenta cuenta, double monto)
        {
            this.cuenta = cuenta;
            this.monto = monto;
        }

        public void execute()
        {
            this.cuenta.depositar(this.monto);
        }
    }
}
