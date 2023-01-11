using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Strategy__Patrón_de_comportamiento_
{
    internal class AntivirusAvanzado : AnalisisAvanzado
    {
        public override void Iniciar()
        {
            Console.WriteLine("Antivirus Avanzado - Análisis avanzado iniciado");
        }
        public override void AnalizarMemoria()
        {
            try
            {
                Console.WriteLine("Analizando Memoria RAM...");
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public override void AnalizarKeyLoggers()
        {
            try
            {
                Console.WriteLine("Analizando en busca de KeyLoggers...");
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public override void AnalizarRootKits()
        {
            try
            {
                Console.WriteLine("Analizando en busca de RootKits...");
                Thread.Sleep(1500);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public override void DescomprimirZip()
        {
            try
            {
                Console.WriteLine("Analizando archivos zip...");
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public override void Detener()
        {
            Console.WriteLine("Antivirus Avanzado - Análisis avanzado finalizado");
        }
    }
}
