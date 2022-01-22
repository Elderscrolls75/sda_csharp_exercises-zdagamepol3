using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void CheckControlNumber(string PESELText)
        {
            int[] PESELNumbers = new int[11];
            for (int i = 0; i < PESELText.Length; i++)
            {
                PESELNumbers[i] = PESELText[i] - '0';
            }

            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int sumOfMultiplying = 0;
            

            for (int i = 0; i < PESELNumbers.Length-1; i++)
            {
                sumOfMultiplying += PESELNumbers[i] * weights[i];
            }
            int moduloOfSum = sumOfMultiplying % 10;
            if (moduloOfSum == PESELNumbers[10])
            {
                Console.WriteLine("Liczba kontrolna poprawna!");
            }
            else
            {
                Console.WriteLine("Liczba kontrolna niepoprawna!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj PESEL, którego liczba kontrolna ma zostać sprawdzona: ");
            string PESEL = "55030101230";
            Console.WriteLine("Liczba kontrolna podanego PESELu to: ");
            Console.WriteLine(PESEL[10]);
            CheckControlNumber(PESEL);
        }
    }
}
