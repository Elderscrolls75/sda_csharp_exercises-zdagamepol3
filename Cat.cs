using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Cat : IAnimal
    {
        protected string name;

        public Cat(string name)
        {
            this.name = name;
        }

        public string MakeSound()
        {
            return string.Format("{0} wydaje dźwięk: miaaaau!", name);
        }

        public string WhatAnimal()
        {
            return "Kot";
        }

    }
}
