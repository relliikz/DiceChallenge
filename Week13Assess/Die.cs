using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Week13Assess;

namespace Week13Assess
{
    public class DieClass
    {
        public int Sides { get; set; }

        public void Die()
        {
            this.Sides = 6;
        }

        public DieClass(int Sides)
        {
            this.Sides = Sides;
        }

        public int Roll()
        {
            Console.WriteLine("Rolling a " + this.Sides + "sided dice");
            Random rnd = new Random();
            return rnd.Next(1, this.Sides + 1);
        }
    }
}