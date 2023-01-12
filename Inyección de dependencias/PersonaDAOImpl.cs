using Inyección_de_dependencias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO__Patrón_arquitectónico_
{
    internal class PersonaDAOImpl : PersonaDAO
    {
        private Conexion conexion;
        public PersonaDAOImpl(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Persona> listarTodos()
        {
            //usando this.conexion
            Console.WriteLine("Listando...");
            return null;
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

        public void mostrarNombre(Persona persona)
        {
            Console.WriteLine("Nombre de la persona: " + persona.getNombres());
        }

        public void mostrarNombre()
        {
            throw new NotImplementedException();
        }
    }
}
