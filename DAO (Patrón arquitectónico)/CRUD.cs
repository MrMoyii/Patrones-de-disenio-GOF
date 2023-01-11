using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO__Patrón_arquitectónico_
{
    internal interface CRUD<T>
    {
        List<T> listarTodos();
        T leerPorId(int id);
        void registrar(T persona);
        void actualizar(T persona);
        void eliminar(int id);
    }
}
