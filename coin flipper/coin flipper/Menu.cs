using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coin_flipper
{
    public static class Menu
    {
        public static void Start()
        {
            Console.Clear();
            var inputvalid = false;
            do
            {
                Console.Clear();
                ConsoleIO.DisplayMenu();
                var input = Console.ReadLine();
                int intinput;


                if (int.TryParse(input, out intinput))
                {
                    switch (intinput)
                    {
                        case 1:
                            inputvalid = true;
                            var dierollworkflow = new DieRollWorkflow();
                            dierollworkflow.Execute();
                            continue;
                        case 2:
                            inputvalid = true;
                            var flipcoinworkflow = new CoinFlipWorkflow();
                            flipcoinworkflow.Execute();
                            continue;
                        case 3:
                            inputvalid = true;
                            return;
                        default:
                            ConsoleIO.DisplayText("Error: Invalid Selection",ConsoleColor.DarkRed);
                            Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    ConsoleIO.DisplayText("You must enter a whole number!", ConsoleColor.DarkRed);
                    Console.ReadLine();
                }
            } while (inputvalid == false);
        }
    }
}
