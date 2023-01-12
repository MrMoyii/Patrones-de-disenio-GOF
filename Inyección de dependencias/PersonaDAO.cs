using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO__Patrón_arquitectónico_
{
    internal interface PersonaDAO : CRUD<Persona>
    {
        void mostrarNombre();
    }
}
