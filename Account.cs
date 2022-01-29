using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Account
    {
        public decimal Balance { get; protected set; }

        public Account(decimal balance)
        {
            this.Balance = balance;
        }
        public void IncreaseBalance(decimal increaser)
        {
            Balance += increaser;
        }
        public virtual decimal RealBalance
        {
            get { return Balance; }
        }
    }
}
