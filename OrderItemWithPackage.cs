using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class OrderItemWithPackage : OrderItem
    {
        protected string packageName;
        protected decimal packagePrice;
        public OrderItemWithPackage(string productName, int productQuantity, decimal unitPrice, string packageName, decimal packagePrice)
            : base(productName, productQuantity, unitPrice)
        {
            this.packageName = packageName;
            this.packagePrice = packagePrice;
        }

        public override decimal GetValue()
        {
            decimal orderValue;
            orderValue = productQuantity * unitPrice + packagePrice * productQuantity;
            return orderValue;
        }

        public override string ToString()
        {
            return string.Format("{0}, cena: {1}zł, opakowanie: {2}, cena opakowania: {3}zł, {4}szt, wartość: " + GetValue() + "zł", productName, unitPrice,
                packageName, packagePrice, productQuantity);
        }
    }
}
