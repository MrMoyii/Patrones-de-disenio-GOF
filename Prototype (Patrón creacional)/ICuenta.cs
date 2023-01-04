using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype__Patrón_creacional_
{
    internal interface ICuenta : ICloneable
    {
        ICuenta Clonar();
    }
}
