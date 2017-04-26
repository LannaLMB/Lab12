using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Validation
    {

        // Method to Get Valid String
        public static string GetValidString()
        {
            string Input = Console.ReadLine().ToUpper();

            // Validate Input
            while (((string.IsNullOrEmpty(Input)) || (string.IsNullOrWhiteSpace(Input))))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.Write("You MUST Enter a Word  --->   ");
                Console.ForegroundColor = ConsoleColor.Green;
                Input = Console.ReadLine().ToUpper();

            }
            return Input;
        }


        // Method to Get Valid Game Choices
        public static string GetValidChoice()
        {
            string Input = Console.ReadLine().ToUpper();


            while ((Input != "ROCK") && (Input != "PAPER") && (Input != "SCISSORS"))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You MUST Choose From The Following Options:  \n  ---  Rock\n  ---  Paper\n  ---  Scissors");
                Console.ForegroundColor = ConsoleColor.Green;
                Input = Console.ReadLine().ToUpper();
            }

            return Input;
        }
    }
}