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
            Console.ReadLine();
            Console.WriteLine("");



            // Who Does The User Want To Play Against?
            Console.WriteLine("Would You Like to Play Against The Rock or The Random?  Please Type the Word Rock or Random");
            string Opponent = Console.ReadLine().ToUpper();



            // Player's Choice
            Console.WriteLine();
            Console.WriteLine($"You Chose {Opponent} -- Let's Begin!\n");



            // Create Instance of Human Player --- Get Human Version of GetRoshambo Method
            HumanPlayer h = new HumanPlayer();
            string HumanChoice = h.GetRoshambo();



            // Create Instance of Random Player --- Get Random Version of GetRoshambo Method
            RandomPlayer rp = new RandomPlayer();
            string CompChoice = rp.GetRoshambo();
            Console.WriteLine(CompChoice);




            //if (h.GetRoshambo() =



        }
    }
}
