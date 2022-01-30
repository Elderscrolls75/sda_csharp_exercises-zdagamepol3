using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Rectangle
    {
        private int width;
        private int length;

        private decimal Area()
        {
            decimal area;
            area = width * length;
            return area;
        }

        private decimal Circuit()
        {
            decimal circuit;
            circuit = 2 * width + 2 * length;
            return circuit;
        }

        public void Show()
        {
            Console.WriteLine("Pole powierzchni wynosi: " + Area());
            Console.WriteLine("Obwód wynosi: " + Circuit());
        }

        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }

        public static void PrintClassName()
        {
            Console.WriteLine(typeof(Rectangle).Name);
        }
    }
}
