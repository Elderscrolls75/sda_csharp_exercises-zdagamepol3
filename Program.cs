using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Point punkt = new Point(5, 3);
            punkt.Print();
            punkt.Move(2, 5);
            punkt.Print();
        }
    }
}
