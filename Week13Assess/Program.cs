using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Week13Assess;

namespace Week13Assess
{
    class Program
    {
        static CIGame DiceRoller = new CIGame();
        static void Main()
        {
            string filePath = "./rolls.txt";
            if (File.Exists(filePath))
            {
                string[] arr = File.ReadAllLines(filePath);
                foreach (string s in arr)
                {
                    DiceRoller.Results.Add(int.Parse(s));
                }
            }
            while (true)
            {
                int inputNum;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the DiceRoll Menu!");
                    Console.WriteLine("Please enter a number (1-8) for your selection");
                    Console.WriteLine("1. Add a Die\n2. Roll one Dice\n3. List all Rolls\n4. Delete All Rolls\n5. Roll All Dice\n6. Calculate Key Values\n7. Save all\n8. Exit");
                    string input = Console.ReadLine().Trim();
                    if (Int32.TryParse(input, out inputNum) && inputNum > 0 && inputNum < 9)
                    {
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("!!Incorrect Input!!");
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                }

                switch (inputNum)
                {
                    case 1:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("How many sides would you like your dice to be?");
                            string input = Console.ReadLine().Trim();
                            if (Int32.TryParse(input, out int sides) && inputNum > 0)
                            {
                                DiceRoller.AddDie(sides);
                                break;
                            }
                        }
                        Console.WriteLine("Dice Created");
                        Console.WriteLine("Press enter to return to menu");
                        Console.ReadLine();
                        break;
                    case 2:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("How many sides does this dice have?");
                            string input = Console.ReadLine().Trim();
                            if (Int32.TryParse(input, out int sides) && inputNum > 0)
                            {
                                DieClass dice = new DieClass(sides);
                                Console.WriteLine("Rolling a " + sides + "sided dice result was: " + dice.Roll());
                                Console.WriteLine("Hit enter to continue");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect Input");
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        listAllRolls();
                        Console.WriteLine("Press enter to return to menu");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        using (StreamWriter writer = new StreamWriter("./rolls.txt", false))
                        {
                            writer.Write("");
                        }
                        break;
                    case 5:
                        Console.Clear();
                        if (DiceRoller.Dice == null)
                        {
                            Console.WriteLine("You must create a die before you can roll it");
                        }
                        else
                        {
                            DiceRoller.RollAllDice();
                            Console.WriteLine("Rolled all dice");
                        }
                        Console.WriteLine("Press enter to return to menu");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine($"Average:  {DiceRoller.GetAverage()}\nTotal: {DiceRoller.GetTotal()}");
                        Console.WriteLine("Press enter to return to menu");
                        Console.ReadLine();
                        break;
                    case 7:
                        using (StreamWriter writer = new StreamWriter("./rolls.txt", false))
                        {
                            foreach (int i in DiceRoller.Results)
                            {
                                writer.WriteLine(i);
                            }
                        }
                        Console.WriteLine("Saved");
                        Console.WriteLine("Press enter to return to menu");
                        Console.ReadLine();
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void listAllRolls()
        {
            while (true)
            {
                Console.Clear();
                foreach (int roll in DiceRoller.Results)
                {
                    Console.WriteLine(roll);
                }
            }
        }
    }
}