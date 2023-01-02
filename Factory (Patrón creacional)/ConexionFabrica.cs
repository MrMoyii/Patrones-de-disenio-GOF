using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory__Patrón_creacional_
{
    internal class ConexionFabrica
    {
        public IConexion GetConexion(string motor)
        {
            if (motor == null)
                return new ConexionVacia();

            if (motor.Equals("MYSQL"))
                return new ConexionMySQL();
            else if (motor.Equals("ORACLE"))
                return new ConexionOracle();
            else if (motor.Equals("POSTGRE"))
                return new ConexionPostgreSQL();
            else if (motor.Equals("SQL"))
                return new ConexionSQLServer();

            return new ConexionVacia();
        }
    }
}
