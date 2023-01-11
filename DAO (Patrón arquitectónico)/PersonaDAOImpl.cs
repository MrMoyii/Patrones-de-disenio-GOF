using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO__Patrón_arquitectónico_
{
    internal class PersonaDAOImpl : PersonaDAO
    {
        public List<Persona> listarTodos()
        {
            List<Persona> lista = new List<Persona>();
            Persona per = new Persona();
            per.setID(1);
            per.setNombres("Moyi");

            lista.Add(per);

            per = new Persona();
            per.setID(2);
            per.setNombres("Code");

            lista.Add(per);

            return lista;
        }

        public Persona leerPorId(int id)
        {
            //Logica
            //Esto esta muy mal
            return null;
        }

        public void registrar(Persona persona)
        {
            Console.WriteLine("Persona " + persona.getNombres() + " registrada");
        }

        public void actualizar(Persona persona)
        {
            Console.WriteLine("Persona " + persona.getNombres() + " actualizada");
        }

        public void eliminar(int id)
        {
            Console.WriteLine("id " + id + " eliminado");
        }

    }
}
