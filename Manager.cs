using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Manager : Employee
    {
        public Manager(string name, string surname, double salary) : base(name, surname, salary)
        {
            this.salary = salary * 1.1;
        }
    }
}
