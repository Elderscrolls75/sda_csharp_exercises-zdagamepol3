using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Dog : IAnimal
    {
        protected string name;
        protected readonly string dogSound = "hau hau!";

        public Dog(string name)
        {
            this.name = name;
        }

        public string MakeSound()
        {
            return string.Format("{0} wydaje dźwięk: {1}", name, dogSound);
        }

        public string WhatAnimal()
        {
            return "Pies";
        }
    }
}
