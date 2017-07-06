using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coin_flipper
{
    public class CoinFlipWorkflow
    {
        public void Execute()
        {
            
            bool validinput = false;
            do
            {
                Console.Clear();
                ConsoleIO.DisplayMenuHeader("Flip Coin");
                Console.WriteLine("How many coins will you flip?");
                int numberOfCoins;
                var input = Console.ReadLine();
                if (int.TryParse(input, out numberOfCoins) && int.Parse(input) > 0)
                {
                    validinput = true;
                    Console.WriteLine($"Flipping {numberOfCoins} coins...");

                    List<int> results = new List<int>();

                    var rng = new Random();
                    int headsCount = 0;
                    int tailsCount = 0;

                    for (int i = 0; i < numberOfCoins; i++)
                    {
                        results.Add(rng.Next(0, 2));
                    }

                    foreach (var result in results)
                    {
                        if (result == 0)
                        {
                            tailsCount++;
                        }
                        else
                        {
                            headsCount++;
                        }
                    }

                    foreach (var result in results)
                    {
                        if (result == 0)
                        {
                            Console.WriteLine("Result was Tails.");
                        }
                        else
                        {
                            Console.WriteLine("Result was Heads.");
                        }
                    }
                    ConsoleIO.DisplayText($"The number of tails is {tailsCount}", ConsoleColor.Yellow);
                    ConsoleIO.DisplayText($"The number of heads is {headsCount}", ConsoleColor.Yellow);
                    Console.WriteLine("Any key to return to menu.");
                    Console.ReadLine();
                    Menu.Start();
                }
                else
                {
                    ConsoleIO.DisplayText("Invalid input!", ConsoleColor.DarkRed);
                    Console.ReadLine();
                }

            } while (validinput == false);
        }
    }
}
