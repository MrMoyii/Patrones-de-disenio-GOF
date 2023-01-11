using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO__Patrón_arquitectónico_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonaDAO dao = new PersonaDAOImpl();
            dao.listarTodos().ForEach(x => { Console.WriteLine(x.getNombres()); });

            Console.ReadKey();
        }
    }
}
