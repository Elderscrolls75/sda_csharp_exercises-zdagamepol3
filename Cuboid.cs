using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Cuboid
    {
        public int Length { get; protected set; }
        public int Width { get; protected set; }
        public int Height { get; protected set; }

        public Cuboid(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double GetVolume()
        {
            double volume;
            volume = Width * Length * Height;
            return volume;
        }

        public static int CompareCuboids(Cuboid cuboid1, Cuboid cuboid2)
        {
            if (cuboid1.GetVolume() > cuboid2.GetVolume())
            {
                return 1;
            }
            else if (cuboid1.GetVolume() == cuboid2.GetVolume())
            {
                return 0;
            }
            else
            {
                return -1;
            }

        }
    }
}
