using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericMethods
    {
        public T ReturnT<T>() where T: new()
        {
            return new T();
        }
    }
}
