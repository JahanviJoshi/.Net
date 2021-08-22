using System;
using System.Collections.Generic;
using System.Text;

namespace multipleinheritance
{
    class rec: shape, cost
    {
        public rec(int a, int b) : base(a, b) { }

        public int getarea()
        { return height * width; }

        public int getcost(int a)
        { return a * 30; }
    }
}
