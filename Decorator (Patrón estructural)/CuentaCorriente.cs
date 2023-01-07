﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator__Patrón_estructural_
{
    internal class CuentaCorriente : ICuentaBancaria
    {
        public void abrirCuenta(Cuenta c)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Se abrio una cuenta de Corriente");
            Console.WriteLine("Cliente: " + c.getCliente());
        }
    }
}
