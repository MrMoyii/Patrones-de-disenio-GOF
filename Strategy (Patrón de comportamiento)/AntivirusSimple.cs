using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Strategy__Patrón_de_comportamiento_
{
    internal class AntivirusSimple : AnalisisSimple
    {
        public override void Iniciar()
        {
            Console.WriteLine("Antivirus Simple - Análisis simple iniciado");
        }

        public override void SaltarZip()
        {
            try
            {
                Console.WriteLine("Analizando...");
                Thread.Sleep(2500);
                Console.WriteLine("No se pudo analizar archivos con extension '.zip");
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }

        public override void Detener()
        {
            Console.WriteLine("Antivirus Simple - Análisis simple finalizado");
        }
    }
}
