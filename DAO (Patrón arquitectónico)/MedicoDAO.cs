using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO__Patrón_arquitectónico_
{
    internal interface MedicoDAO : CRUD<Medico>
    {
        void curar();
    }
}
