using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Order produkt1 = new OrderItem("Chleb", 5, 3.50);
            Order produkt2 = new OrderItemWithPackage("Mleko", 5, 2.20, "butelka", 1);
            Order produkt3 = new OrderItem("Kapusta", 2, 5.20);
            Order produkt4 = new OrderItemWithPackage("Monitor", 1, 1100, "karton", 10);
            Order[] produkty = { produkt1, produkt2, produkt3, produkt4 };
            double wartośćZamówienia = 0;

            foreach (Order i in produkty)
            {
                wartośćZamówienia += i.GetValue();
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("Wartośc zamówienia wynosi: " + wartośćZamówienia + "zł");
        }


    }
}
