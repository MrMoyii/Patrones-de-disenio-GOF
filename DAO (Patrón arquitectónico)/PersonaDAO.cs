using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO__Patrón_arquitectónico_
{
    internal interface PersonaDAO
    {
        List<Persona> listarTodos();
        Persona leerPorId(int id);
        void registrar(Persona persona);
        void actualizar(Persona persona);
        void eliminar(int id);
    }
}
