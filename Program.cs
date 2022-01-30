using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape koło1 = new Circle(5);
            Shape kwadrat = new Square(12);
            Shape koło2 = new Circle(8);

            Shape[] kształtyNaŚcianę = { koło1, kwadrat, koło2 };

            decimal sumaPól = 0;
            foreach (Shape s in kształtyNaŚcianę)
            {
                sumaPól += s.GetArea();
            }

            Console.WriteLine(sumaPól);
        }
    }
}
