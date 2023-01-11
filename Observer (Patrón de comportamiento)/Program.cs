using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer__Patrón_de_comportamiento_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subjet = new Subject();

            new SolObservador(subjet);
            new PesoMXObservador(subjet);
            new PesoARGObservador(subjet);

            Console.WriteLine("Si desea cambiar 10 dolares obtendra : ");
            subjet.setEstado(10);
            Console.WriteLine("----------------------");
            Console.WriteLine("Si desea cambiar 100 dolares obtendra : ");
            subjet.setEstado(100);

            Console.ReadKey();
        }
    }
}
