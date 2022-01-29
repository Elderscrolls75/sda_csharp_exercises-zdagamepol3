using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class OrderItem : Order
    {
        protected string productName;
        protected int productQuantity;
        protected double unitPrice;

        public OrderItem(string productName, int productQuantity, double unitPrice)
        {
            this.productName = productName;
            this.productQuantity = productQuantity;
            this.unitPrice = unitPrice;
        }

        public override double GetValue()
        {
            double orderValue;
            orderValue = productQuantity * unitPrice;
            return orderValue;
        }

        public override string ToString()
        {
            return string.Format("{0}, cena: {1}zł, {2}szt, wartość: " + GetValue() + "zł", productName, unitPrice, productQuantity);
        }
    }
}
