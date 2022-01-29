using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Employee : Person
    {
        protected int salary;

        public Employee(string firstName, string lastName, int dateOfBirth, int salary) : base(firstName, lastName, dateOfBirth)
        {
            this.salary = salary;   
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public override string GetInfo()
        {
            return string.Format("Imię: {0}, Nazwisko: {1}, Data Urodzenia: {2}, Pracownik, Wynagrodzenie: {3}", firstName, lastName, dateOfBirth, salary);
        }
    }
}
