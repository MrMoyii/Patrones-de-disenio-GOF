﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer__Patrón_de_comportamiento_
{
    internal class PesoARGObservador : Observador
    {
        private double valorCambio = 29.86;

        public PesoARGObservador(Subject sujeto)
        {
            this.sujeto = sujeto;
            this.sujeto.agregar(this);
        }

        public override void actualizar()
        {
            Console.WriteLine("ARG: " + (sujeto.getEstado() * valorCambio));
        }
    }
}
