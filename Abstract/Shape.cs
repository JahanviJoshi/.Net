using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    abstract class Shape
    {
        public int length;
        public int width;
        public void set(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        public abstract int area();
    }

    class rectangle : Shape
    {
        public override int area()
        {
            return (width * length);
        }

    }
}
