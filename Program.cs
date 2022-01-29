using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog zula = new Dog("Zula");
            Cat mruczek = new Cat("Mruczek");
            Cat szarek = new Cat("Szarek");
            Dog szarik = new Dog("Szarik");
            Cat kuflina = new Cat("Kuflina");

            IAnimal[] zwierzaki = { zula, mruczek, szarek, szarik, kuflina };

            foreach (IAnimal i in zwierzaki)
            {
                Console.WriteLine("Ten zwierzak to: " + i.WhatAnimal());
                Console.WriteLine(i.MakeSound());
                
                if (i is Dog)
                {
                    Console.WriteLine("Typ: Dog");
                }
                else
                {
                    Console.WriteLine("Typ: Cat");
                }
            }
        }
    }
}
