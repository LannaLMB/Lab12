using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RandomPlayer : Player  // Inherits Player Class
    {
        // Get Method GetRoshambo() To Work With RandomPlayer Class
        public override string GetRoshambo()
        {
            // Declare Array For Random Choice
            string[] Game = { "Rock", "Paper", "Scissors" };

            // Get Random String From Array
            int index = new Random().Next(Game.Length);
            string CompChoice = (Game[index]);
            return CompChoice;
        }
    }
}

