using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype__Patrón_creacional_
{
    internal class CuentaAHImpl : ICuenta
    {
        private string tipo;
        private double monto;

        public CuentaAHImpl()
        {
            tipo = "AHORRO";
        }
        public ICuenta Clonar()
        {
            CuentaAHImpl cuenta = null;

            try
            {
                cuenta = (CuentaAHImpl)MemberwiseClone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return cuenta;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public string toString()
        {
            return "CuentaAHImpl [tipo= " + tipo + ", monto= " + monto + "]";
        }
        public void setMonto(double monto) { this.monto = monto; }
        public double getMonto() { return monto; }
    }
}
