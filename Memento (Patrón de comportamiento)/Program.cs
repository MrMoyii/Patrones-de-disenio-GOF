using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento__Patrón_de_comportamiento_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Memento es un patrón de diseño de comportamiento que
              permite guardar y restaurar el estado previo de un objeto
              sin revelar los detalles de su implementación.*/

            string nombreJuego = "Crash Bandicoot";

            Juego juego= new Juego();
            juego.setNombre(nombreJuego);
            juego.setCheckpoint(1);

            Caretaker caretaker= new Caretaker();
            Originator originator= new Originator();

            juego = new Juego();
            juego.setNombre(nombreJuego);
            juego.setCheckpoint(2);
            originator.setEstado(juego);

            juego = new Juego();
            juego.setNombre(nombreJuego);
            juego.setCheckpoint(3);
            originator.setEstado(juego);

            caretaker.addMemento(originator.guardar()); //Estado posicion 0

            juego = new Juego();
            juego.setNombre(nombreJuego);
            juego.setCheckpoint(4);
            
            originator.setEstado(juego);
            caretaker.addMemento(originator.guardar()); //Estado posicion 1

            juego = new Juego();
            juego.setNombre(nombreJuego);
            juego.setCheckpoint(5);

            originator.setEstado(juego);
            originator.restaurar(caretaker.getMemento(0));

            juego = originator.getEstado();
            Console.WriteLine(juego.toString());

            Console.ReadKey();
        }
    }
}
