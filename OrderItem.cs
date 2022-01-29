using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class OrderItem
    {
        protected string productName;
        protected int productQuantity;
        protected decimal unitPrice;

        public OrderItem(string productName, int productQuantity, decimal unitPrice)
        {
            this.productName = productName;
            this.productQuantity = productQuantity;
            this.unitPrice = unitPrice;
        }

        public virtual decimal GetValue()
        {
            decimal orderValue;
            orderValue = productQuantity * unitPrice;
            return orderValue;
        }

        public override string ToString()
        {
            return string.Format("{0}, cena: {1}zł, {2}szt, wartość: " + GetValue() + "zł", productName, unitPrice, productQuantity);
        }
    }
}
