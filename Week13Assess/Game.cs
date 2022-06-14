using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Week13Assess;

namespace Week13Assess
{
    public abstract class Game
    {
        public List<DieClass> Dice { get; set; }

        public Game() {
            Dice = new List<DieClass>();
        }


        public abstract int RollAllDice();

        public abstract void AddDie(int Sides);

    }
}