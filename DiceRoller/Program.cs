using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad_Console
{
    class Program
    {
        public static Random _random = new Random();
        public static bool keepGoing = true;
        public static int diceCount;

        static void Main(string[] args)
        {
            Console.WriteLine("Dice Roller");
            Console.WriteLine();

            while (keepGoing)
            {
                Console.WriteLine("== DICE ROLLER ==");
                Console.Write("How many dice would you like to roll?: ");
                diceCount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                DiceRoller();
                Console.WriteLine();
                Console.Write("Press ENTER to roll again or type \"Quit\" to exit the application. ");
                string answer = Console.ReadLine();
                if (answer.ToLower().Contains("quit"))
                {
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine();
                }
            }

        }// end Main

        static void DiceRoller()
        {
            for (int i = 1; i <= diceCount; i++)
            {
                Console.WriteLine(">> Die " + i + ": " + _random.Next(1, 7));
            }
        }



    }// end Class
}// end Namespace