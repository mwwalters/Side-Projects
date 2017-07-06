using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coin_flipper
{
    public static class ConsoleIO
    {
        public static string PromptForInput(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            return input;
        }

        public static void DisplayText(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void DisplayMenuHeader(string menutitle)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"\t{menutitle}");
            Console.WriteLine("----------------------------------------------------");
        }

        public static void DisplayMenu()
        {
            Console.WriteLine(@"               (( _______");
            Console.WriteLine(@"     _______     /\O    O\");
            Console.WriteLine(@"    /O     /\   /  \      \");
            Console.WriteLine(@"   /   O  /O \ / O  \O____O\ ))");
            Console.WriteLine(@"((/_____O/    \     /O     /");
            Console.WriteLine(@"  \O    O\    /\   /   O  /");
            Console.WriteLine(@"   \O    O\ O/  \ /_____O/");
            Console.WriteLine(@"    \O____O\/ ))       ))");
            Console.WriteLine(@"  ((");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\tWelcome to DieRoller!");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\tPlease select from the follwing");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\t1. Roll dice");
            Console.WriteLine("\t2. Flip coins");
            Console.WriteLine("\t3. Quit");
        }
    }
}
