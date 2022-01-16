using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            static void Cennik()
            {
                int cena = Convert.ToInt32(Console.ReadLine());
                int liczbaLinii = Convert.ToInt32(Console.ReadLine());

                for (int k = 1; k < liczbaLinii+1; k++)
                {
                    Console.WriteLine("Liczba sztuk: " + k + " łączna cena: " + k * cena);
                }
            }

            Cennik();
        }
    }
}
