using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuboid cuboid1 = new Cuboid(10, 12, 5);
            Cuboid cuboid2 = new Cuboid(12, 4, 28);

            if (Cuboid.CompareCuboids(cuboid1, cuboid2) == 1)
            {
                Console.WriteLine("Większa jest objętość pierwszego prostopadłościanu");
            }
            else if (Cuboid.CompareCuboids(cuboid1, cuboid2) == 0)
            {
                Console.WriteLine("Objętości prostopadłościanów są sobie równe");
            }
            else
            {
                Console.WriteLine("Większa jest objętość drugiego prostopadłościanu");
            }
        }
    }
}
