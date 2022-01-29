using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    abstract class Order
    {
        public virtual double GetValue()
        {
            return 0;
        }
    }
}
