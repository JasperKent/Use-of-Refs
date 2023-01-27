using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refs
{
    internal ref struct MyStruct 
    {
        public MyStruct(ref int val)
        {
            Value = ref val;
        }

        public readonly ref readonly int Value;
    }
}
