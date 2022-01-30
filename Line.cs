using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Line
    {
        protected Point Start { get; set; }
        protected Point End { get; set; }
        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public double GetLength()
        {
            double length = 0;
            length = Math.Sqrt(Math.Pow((End.X - Start.X), 2) + Math.Pow((End.Y - Start.Y), 2));
            return length;
        }

    }
}
