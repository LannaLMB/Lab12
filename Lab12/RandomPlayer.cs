using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RandomPlayer : Player  // Inherits Player Class
    {
        // This Class Will Choose Rock, Paper, or Scissors At Random


        // Declare Variable
        private string RandomChoice;


        #region Properties

        // Property - Random Choice
        public string rRandomChoice
        {
            set
            {
                RandomChoice = value;
            }

            get
            {
                return RandomChoice;
            }
        }

        #endregion



        // Constructor
        public RandomPlayer(string RandomChoiceInput)
        {
            RandomChoice = RandomChoiceInput;
        }


        // Default Value
        public RandomPlayer()
        {
            RandomChoice = "Scissors";
        }

    }
}
