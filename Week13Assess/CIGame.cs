using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Week13Assess;

namespace Week13Assess
{
   public class CIGame: Game
    {
        public string Name;

        public List<int> Results;

        public double GetAverage(){
            //Returns the average of the results table
           int total = GetTotal();           
            double average = total / (double)Results.Count();
            return average;
        }

        public int GetTotal(){
            //Returns the sum of the results table
            return Results.Sum();
        }

        public override int RollAllDice()
        {
            foreach (DieClass Die in Dice)
            {
                Die.Roll();
            }
            return 1;
        }

        public override void AddDie(int Sides)
        {
            Console.WriteLine("How many dice would you like to add?");
            string amount = Console.ReadLine();
            Dice.Add(new DieClass(Sides));
        }
    }
}