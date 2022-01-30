using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Point
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int moveX, int moveY)
        {
            X += moveX;
            Y += moveY;
        }

        public void Print()
        {
            Console.WriteLine("Obecne współrzędne punktu: ");
            Console.WriteLine(X);
            Console.WriteLine(Y);
        }
    }
}
