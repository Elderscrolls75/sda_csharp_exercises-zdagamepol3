using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle prostokąt = new Rectangle(5, 7);

            prostokąt.Show();
            Rectangle.PrintClassName();
        }
    }
}
