using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void DoNotRepeatNum(int[] numArray)
        {
            int NON_UNIQUE_NUMBER = -1;
            for (int i = 0; i < numArray.Length; i++)
            {
                if (i != NON_UNIQUE_NUMBER)
                {
                    for (int j = i + 1; j < numArray.Length; j++)
                    {
                        if (numArray[j] == numArray[i])
                        {
                            numArray[i] = NON_UNIQUE_NUMBER;
                        }
                    }
                }
            }
            foreach (int i in numArray)
            {
                if (i != NON_UNIQUE_NUMBER)
                {
                    Console.Write(i + " ");
                }
            }


        }

        static void Main(string[] args)
        {
            int[] numArray = { 2, 5, 1, 5, 7, 1, 3, 2, 5 };
            Console.WriteLine("Podstawowa tablica wygląda tak: ");
            Console.WriteLine();
            foreach (int i in numArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Tablica bez powtórzeń wygląda zaś tak: ");
            Console.WriteLine();
            DoNotRepeatNum(numArray);
        }
    }
}
