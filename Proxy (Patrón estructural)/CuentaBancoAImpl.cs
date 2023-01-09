using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy__Patrón_estructural_
{
    internal class CuentaBancoAImpl : ICuenta
    {
        public Cuenta retirarDinero(Cuenta cuenta, double monto)
        {
            double saldoActual = cuenta.getSaldoInicial() - monto;
            cuenta.setSaldoInicial(saldoActual);
            Console.WriteLine("Saldo actual: " + cuenta.getSaldoInicial());
            return cuenta;
        }
        public Cuenta depositarDinero(Cuenta cuenta, double monto)
        {
            double saldoActual = cuenta.getSaldoInicial() + monto;
            cuenta.setSaldoInicial(saldoActual);
            Console.WriteLine("Saldo actual: " + cuenta.getSaldoInicial());
            return cuenta;
        }

        public void mostrarSaldo(Cuenta cuenta)
        {
            Console.WriteLine("Saldo actual: " + cuenta.getSaldoInicial());
        }

    }
}
