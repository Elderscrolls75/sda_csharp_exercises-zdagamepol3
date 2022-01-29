using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Bank
    {
        public List<Account> listaKont = new List<Account>();
        public Bank()
        {
           
        }
        public void AddAccount(Account konto)
        {
            listaKont.Add(konto);
        }

        public void GetValue()
        {
            decimal sum = 0;
            foreach (Account a in listaKont)
            {
                sum += a.RealBalance;
            }

            Console.WriteLine("Łączna wartość wszystkich kont wynosi: " + sum);
        }
    }
}
