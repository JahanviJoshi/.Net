using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    class Rectangle : Shape
    {
        public override int area()
        {
            return (width * length);
        }
    }
}
