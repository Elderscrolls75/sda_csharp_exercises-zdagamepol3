using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Triangle(int linesQuantity)
        {
            for (int i = 0; i < linesQuantity; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = linesQuantity-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę linii: ");
            int linesQuantity = Convert.ToInt32(Console.ReadLine());

            Triangle(linesQuantity);
        }
    }
}
