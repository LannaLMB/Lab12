using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {

            // Welcome Message
            Console.WriteLine("\nWelcome to The Game of Rock --- Paper --- Scissors\n");
            Console.Write("Please Enter Your Name  \n--->  ");
            string Name = Validation.GetValidString();
            Console.WriteLine("");



            // Who Does The User Want To Play Against?
            Console.WriteLine("Would You Like to Play Against The Rock or The Random?  Please Type the Word Rock or Random");
            string Opponent = Validation.GetValidOpponent();



            // Player's Choice
            Console.WriteLine();
            Console.WriteLine($"You Chose {Opponent} -- Let's Begin!\n");

            string ComputerChoice = "";


            // Start Looping Here
            while (true)
            {

                // Create Instance of Human Player --- Get Human Version of GetRoshambo Method
                HumanPlayer h = new HumanPlayer();
                string HumanChoice = h.GetRoshambo();



                // Choose Opponent
                if (Opponent == "RANDOM")
                {

                    // Create Instance of Random Player --- Get Random Version of GetRoshambo Method
                    RandomPlayer rp = new RandomPlayer();
                    ComputerChoice = rp.GetRoshambo();

                }

                else
                {

                    // Create Instance of Rock Player --- Get Rock Version of GetRoshambo Method
                    RockPlayer rock = new RockPlayer();
                    ComputerChoice = rock.GetRoshambo();
                }


                GetOutput(HumanChoice, ComputerChoice, Name);




                // Game Output
                Console.WriteLine();
                Console.WriteLine(Name + ":  " + HumanChoice);
                Console.WriteLine(Opponent + ":  " + ComputerChoice);



                // Call Continue Method
                if (!GetContinue())
                {
                    return;
                }
            }
        }




        // Method To Determine A Winner
        public static void GetOutput(string HumanChoice, string ComputerChoice, string Name)
        {

            if (HumanChoice == ComputerChoice)
            {

                Console.WriteLine("\nTie!");
            }


            else if ((HumanChoice == "ROCK") && (ComputerChoice == "PAPER"))
            {

                Console.WriteLine("\nThe Computer Wins!");
            }


            else if ((HumanChoice == "ROCK") && (ComputerChoice == "SCISSORS"))
            {
                Console.WriteLine("\n" + Name + " Wins!");
            }


            else if ((HumanChoice == "PAPER") && (ComputerChoice == "SCISSORS"))
            {
                Console.WriteLine("\nThe Computer Wins!");
            }

            else if ((HumanChoice == "PAPER") && (ComputerChoice == "ROCK"))
            {
                Console.WriteLine("\n" + Name + " Wins!");
            }


            else if ((HumanChoice == "SCISSORS") && (ComputerChoice == "PAPER"))
            {
                Console.WriteLine("\n" + Name + " Wins!");
            }

            else if ((HumanChoice == "SCISSORS") && (ComputerChoice == "ROCK"))
            {
                Console.WriteLine("\nThe Computer Wins!");
            }
        }





        // Method to Continue
        public static bool GetContinue()
        {
            string Continue;
            //Continue Loop
            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Would You Like to Continue?  (y/n)");
                Continue = Console.ReadLine().ToUpper();
                Console.WriteLine("");
                if (Continue == "Y")
                    return true;

                if (Continue == "N")
                    return false;

                else
                    Console.ForegroundColor = ConsoleColor.Red;  // Red to Alert User Input is Invalid
                Console.WriteLine("Please Enter Y or N");
                Console.ForegroundColor = ConsoleColor.Green;   // Green to Go Back to Original Color
            }
        }
    }
}

