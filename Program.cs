using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee pracownik1 = new Employee("Janek", "Kowalski", 1440.30m);
            Employee pracownik2 = new Employee("Michał", "Najder", 2200);
            Employee manager1 = new Manager("Anna", "Jakubiak", 3350);
            Employee manager2 = new Manager("Kuba", "Świstak", 5000);

            Employee[] pracownicy = { pracownik1, pracownik2, manager1, manager2 };

            foreach (Employee i in pracownicy)
            {
                Console.WriteLine("Pencja wynosi: " + i.Salary + " zł");
            }

        }
    }
}
