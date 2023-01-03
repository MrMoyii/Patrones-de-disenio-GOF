﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Patrón_creacional_
{
    internal class ConexionRESTCompras : IConexionREST
    {
        public void leerURL(string url)
        {
            Console.WriteLine("Conectándose a " + url);
        }
    }
}
