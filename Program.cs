using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderItem produkt1 = new OrderItem("Chleb", 5, 3.50m);
            OrderItem produkt2 = new OrderItemWithPackage("Mleko", 5, 2.20m, "butelka", 1);
            OrderItem produkt3 = new OrderItem("Kapusta", 2, 5.20m);
            OrderItem produkt4 = new OrderItemWithPackage("Monitor", 1, 1100, "karton", 10);
            OrderItem[] produkty = { produkt1, produkt2, produkt3, produkt4 };

            Order zamówienie = new Order(produkty);

            foreach (OrderItem i in produkty)
            {
                Console.WriteLine(i.ToString());
            }

            zamówienie.PrintSummary();

        }

    }
}
