using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Square : Shape
    {
        public int side { get; private set; }
        public Square(int side)
        {
            this.side = side;
        }

        public override decimal GetArea()
        {
            decimal area;
            area = side * side;
            return area;
        }
    }
}
