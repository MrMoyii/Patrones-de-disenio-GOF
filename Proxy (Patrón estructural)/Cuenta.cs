using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy__Patrón_estructural_
{
    internal class Cuenta
    {
        private int idCuenta;
        private string usuario;
        private double saldoInicial;

        public Cuenta(int idCuenta, string usuario, double saldoInicial)
        {
            this.idCuenta = idCuenta;
            this.usuario = usuario;
            this.saldoInicial = saldoInicial;
        }
        public int getIdCuenta() { return idCuenta; }
        public void setIdCuenta(int idCuenta)
        {
            this.idCuenta=idCuenta;
        }
        public string getUsuario() { return usuario; }
        public void setUsuario(string usuario)
        {
            this.usuario = usuario;
        }
        public double getSaldoInicial() { return saldoInicial; }
        public void setSaldoInicial(double saldoInicial)
        {
            this.saldoInicial=saldoInicial;
        }
    }
}
