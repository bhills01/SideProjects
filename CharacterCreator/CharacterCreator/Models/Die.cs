using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    public class Die
    {
        // Constructor 
        public Die(int sides)
        {
            Sides = sides;
        }

        public int Sides { get; set; }

        public int Roll(int numberOfRolls, int sides)
        {
            Random random = new Random();
            int num = random.Next(numberOfRolls * sides);
            return num;
        }
    }
}
