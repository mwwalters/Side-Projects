using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coin_flipper
{
    public class DieRollWorkflow
    {
        public void Execute()
        {

            int validsidesinput;
            bool validInput = false;
            do
            {
                Console.Clear();
                ConsoleIO.DisplayMenuHeader("Roll a die");
                Console.WriteLine("How many sides do you want your die to have?");
                var sidesinput = Console.ReadLine();
                if (int.TryParse(sidesinput, out validsidesinput) && int.Parse(sidesinput) > 0)
                {
                    validInput = true;
                }
                else
                {
                    ConsoleIO.DisplayText("Invalid input!", ConsoleColor.DarkRed);
                    Console.ReadLine();
                }
            } while (validInput == false);

            int validNumberofDice;
            validInput = false;
            do
            {
                Console.Clear();
                ConsoleIO.DisplayMenuHeader("Roll a die");
                Console.WriteLine("How many dice do you want to roll?");

                var numberOfDice = Console.ReadLine();
                if (int.TryParse(numberOfDice, out validNumberofDice) && int.Parse(numberOfDice) > 0)
                {
                    validInput = true;
                }
                else
                {
                    ConsoleIO.DisplayText("Invalid input!", ConsoleColor.DarkRed);
                    Console.ReadLine();
                }

            } while (validInput == false);

            List<int> results = new List<int>();
            var rng = new Random();
            int total = 0;

            for (int i = 0; i < validNumberofDice; i++)
            {
                results.Add(rng.Next(1, validsidesinput));
                total += results[i];
            }

            Console.WriteLine($"Rolling {results.Count().ToString()} D{validsidesinput}s...");

            foreach (var result in results)
            {
                Console.WriteLine($"Roll was {result}.");
            }
            ConsoleIO.DisplayText($"Total of all results is {total}", ConsoleColor.Yellow);
            Console.ReadLine();
            Menu.Start();
        }
    }
}
