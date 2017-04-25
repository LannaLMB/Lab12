using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class HumanPlayer : Player  // Inherits Player Class
    {
        // This Class Will Allow the User to Choose Rock, Paper, or Scissors

        // Declare Variables
        private string Choice;
        private string Name;
        private string Opponent;



        #region Properties

        // Property - Human Choice
        public string HumanChoice
        {
            set
            {
                Choice = value;
            }

            get
            {
                return Choice;
            }  
        }



        // Property - Human Name
        public string HumanName
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }



        // Property - Human Opponent
        public string HumanOpponent
        {
            get
            {
                return Opponent;
            }

            set
            {
                Opponent = value;
            }
        }

        #endregion


        // Constructor
        public HumanPlayer(string ChoiceInput, string NameInput, string OpponentInput)
        {
            Choice = ChoiceInput;
            Name = NameInput;
            Opponent = OpponentInput;
        }



        // Default Values
        public HumanPlayer()
        {
            Choice = "Paper";
            Name = "Lanna";
            Opponent = "Random";
        }
    }
}
