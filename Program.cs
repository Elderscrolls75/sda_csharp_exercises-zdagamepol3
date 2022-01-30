using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Point punkt = new Point(5, 3);
            Point punkt1 = new Point(2, 5);
            Point punkt2 = new Point(1, 4);

            Line odcinek = new Line(punkt, punkt2);
            Console.WriteLine(odcinek.GetLength());
        }
    }
}
