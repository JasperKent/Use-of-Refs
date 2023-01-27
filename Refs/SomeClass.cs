using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refs
{
    internal class SomeClass
    {
        // MyStruct _struct;

 
        private int[] ai = { 1, 2, 3 };


        public ref int Get(int idx)
        {
            return ref ai[idx];
        }
    }
}
