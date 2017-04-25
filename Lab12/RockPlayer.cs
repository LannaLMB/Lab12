using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RockPlayer : Player  // Inherits Player Class
    {

        // Method GetRoshambo - Only Return Rock Value
        public override string GetRoshambo()
        {
            return "Rock";
        }
    }
}
