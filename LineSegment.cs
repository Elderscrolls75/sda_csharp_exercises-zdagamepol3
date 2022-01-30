using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class LineSegment
    {
        public MyPoint Start { get; protected set; }
        public MyPoint End { get; protected set; }

        public LineSegment(MyPoint start, MyPoint end)
        {
            Start = start;
            End = end;
        }

        public LineSegment(int startX, int startY, int endX, int endY)
        {
            Start = new MyPoint(startX, startY);
            End = new MyPoint(endX, endY);
        }

        public double GetLength()
        {
            int xA = Start.X;
            int xB = End.X;
            int yA = Start.Y;
            int yB = End.Y;
            double length = 0;
            length = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2));
            return length;
        }
    }
}
