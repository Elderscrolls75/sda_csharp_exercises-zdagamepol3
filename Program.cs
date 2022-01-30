using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle prostokąt = new Rectangle(5, 7);
            Rectangle prostokąt1 = new Rectangle(1, 6);

            prostokąt.Show();
            Rectangle.PrintClassName();

            Rectangle[] tablicaProstokątów = new Rectangle[3];

            tablicaProstokątów[0] = prostokąt;
            tablicaProstokątów[1] = prostokąt1;
            tablicaProstokątów[2] = new Rectangle(2, 2);

            foreach (Rectangle r in tablicaProstokątów)
            {
                r.Show();
            }

            Console.WriteLine("Tablica prostokątów: ");
            Rectangle.PrintBiggestRectangle(tablicaProstokątów);

        }
    }
}
