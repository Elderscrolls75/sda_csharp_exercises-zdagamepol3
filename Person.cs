using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int dateOfBirth;

        public Person(string firstName, string lastName, int dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
        }

        public virtual string GetInfo()
        {
            return string.Format("Imię: {0}, Nazwisko: {1}, Data Urodzenia: {2}", firstName, lastName, dateOfBirth);
        }
    }
}
