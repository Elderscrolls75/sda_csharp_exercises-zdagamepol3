using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static public void PowerOf(int baza, int potęga)
        { 
            int wynik = baza;

            for (int i = 1; i < potęga; i++)
            {
                wynik = wynik * baza;
            }

            Console.WriteLine(wynik);
        }
        static void Main(string[] args)
        {
            int baza = Convert.ToInt32(Console.ReadLine());
            int potęga = Convert.ToInt32(Console.ReadLine());

            if (potęga == 0)
            {
                Console.WriteLine("Wynik jest równy 1");
            }
            else if (baza == 0)
            {
                Console.WriteLine("Wynik równy jest 0");

            }
            else
            {
                PowerOf(baza, potęga);
            }
        }
    }
}
