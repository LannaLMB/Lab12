using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class HumanPlayer : Player  // Inherits Player Class
    {
        // Get Method GetRoshambo() To Work With HumanPlayer Class --- Return User Input
        public override string GetRoshambo()
        {
           
            Console.WriteLine();
            Console.WriteLine("Please Enter One Of The Following   ----->\tRock\t\tPaper\t\tScissors");
            string HumanChoice = Console.ReadLine().ToUpper();
            return HumanChoice;
        }
        
    }
}
