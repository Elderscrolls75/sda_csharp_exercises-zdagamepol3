using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Circle : Shape
    {
        public int radius { get; private set; }
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public decimal pi = 3.14m;

        public override decimal GetArea()
        {
            decimal area;
            area = pi * radius * radius;
            return area;
        }
    }
}
