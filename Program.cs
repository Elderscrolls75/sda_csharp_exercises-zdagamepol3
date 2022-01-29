using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Person osoba = new Person("Jan", "Kowalski", 1999);
            Person pracownik = new Employee("Kacper", "Świerk", 2001, 2500);
            Person osoba1 = new Person("Kasia", "Kura", 2010);
            Person osoba2 = new Person("Anna", "Matuszak", 1992);
            Person osoba3 = new Person("Michał", "Grzesiak", 2005);
            Person pracownik2 = new Employee("Igor", "Zharikov", 2001, 4200);


            Person[] listaGości = { osoba, pracownik, osoba1, osoba2, pracownik2, osoba3};

            foreach (Person i in listaGości)
            {
                Console.WriteLine(i.GetInfo());
            }
        }
    }
}
