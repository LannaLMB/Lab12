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

            // Create Instances
            HumanPlayer h = new HumanPlayer();

           

            // Welcome Message
            Console.WriteLine("Welcome to Rock - Paper - Scissors\n");
            Console.WriteLine("Please Enter Your Name  --->  ");
            Console.ReadLine();


            // Who Does The User Want To Play Against?
            Console.WriteLine("Would You Like to Play Against The Rock or The Random?  Please Type the Word Rock or Random");
            Console.ReadLine().ToUpper();

            if (h.HumanChoice == "Rock" || h.HumanChoice == "Paper" || h.HumanChoice == "Scissors")


            // Player's Choice
            Console.WriteLine($"You Chose.  Let's Begin!\n");


            // Decision Rock - Paper - Scissors
            Console.WriteLine("Rock - Paper - Scissors");




        }
    }
}
