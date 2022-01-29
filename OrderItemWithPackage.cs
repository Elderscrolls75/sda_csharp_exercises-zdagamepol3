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
        protected double packagePrice;
        public OrderItemWithPackage(string productName, int productQuantity, double unitPrice, string packageName, double packagePrice)
            : base(productName, productQuantity, unitPrice)
        {
            this.packageName = packageName;
            this.packagePrice = packagePrice;
        }

        public override double GetValue()
        {
            double orderValue;
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
