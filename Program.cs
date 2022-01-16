using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Aritmetic(int length, int firstElement, int difference)
        {
            Console.Write(firstElement + ", ");
            for (int i = 1; i < length; i++)
            {
                Console.Write(firstElement * i + difference  + ", ");
            } 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź długość ciągu: ");
            int lenghth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wprowadź pierwszy element ciągu: ");
            int firstElement = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wprowadź różnicę ciągu: ");
            int difference = Convert.ToInt32(Console.ReadLine());

            Aritmetic(lenghth, firstElement, difference);
        }
    }
}
