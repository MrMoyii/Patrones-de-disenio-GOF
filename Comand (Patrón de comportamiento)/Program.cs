using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comand__Patrón_de_comportamiento_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta(1, 200);

            DepositarImpl opDepositar = new DepositarImpl(cuenta, 100); //Comando depositar
            RetirarImpl opRetirar = new RetirarImpl(cuenta, 50); //Comando retirar

            Invoker ivk = new Invoker();
            ivk.recibirOperacion(opDepositar);
            ivk.recibirOperacion(opRetirar);

            ivk.realizarOperacion();

            Console.ReadKey();
        }
    }
}
