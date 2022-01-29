using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class SavingAccount : Account
    {
        public decimal Interest { get; protected set; }
        public SavingAccount(decimal balance, decimal interest) : base(balance)
        {
            this.Interest = interest;
        }
        public override decimal RealBalance
        {
            get { return Balance + Interest; }
        }

        public void IncreaseInterest(decimal increaser)
        {
            Interest += increaser;
        }


    }
}
