using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Account kontoZwykłe = new Account(1400.23m);
            SavingAccount kontoOszczędnoścowe = new SavingAccount(5514.50m, 10.50m);
            SavingAccount dodatkoweKonto = new SavingAccount(2054.50m, 15.50m);

            Console.WriteLine("Zwykłe balans: " + kontoZwykłe.Balance);
            Console.WriteLine("Oszczędnościowe balans bez odsetek: " + kontoOszczędnoścowe.Balance);
            Console.WriteLine("Oszczędnościowe odsetki: " + kontoOszczędnoścowe.Interest);
            Console.WriteLine("Oszczędnościowe balans z odsetkami: " + kontoOszczędnoścowe.RealBalance);

            kontoZwykłe.IncreaseBalance(500m);
            kontoOszczędnoścowe.IncreaseBalance(250m);
            kontoOszczędnoścowe.IncreaseInterest(5m);

            Console.WriteLine("Zwykłe balans: " + kontoZwykłe.Balance);
            Console.WriteLine("Oszczędnościowe balans z odsetkami: " + kontoOszczędnoścowe.RealBalance);
            Console.WriteLine("Oszczędnościowe odsetki: " + kontoOszczędnoścowe.Interest);

            Account[] listaKont = { kontoZwykłe, kontoOszczędnoścowe};

            Bank bank = new Bank();

            foreach (Account i in listaKont)
            {
                bank.AddAccount(i);
            }

            bank.GetValue();

        }
    }
}
