﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comand__Patrón_de_comportamiento_
{
    internal class Cuenta
    {
        private int id;
        private double saldo;

        public Cuenta(int id, double saldo)
        {
            this.id = id;
            this.saldo = saldo;
        }

        public void retirar(double monto)
        {
            this.saldo -= monto;
            Console.WriteLine("[COMANDO RETIRAR] Cuenta: " + id + " Saldo: " + this.saldo);
        }

        public void depositar(double monto)
        {
            this.saldo += monto;
            Console.WriteLine("[COMANDO DEPOSITAR] Cuenta: " + id + " Saldo: " + this.saldo);
        }
    }
}
