using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    public class RollVM
    {
        public Die Die { get; set; }
        public int NumberOfRolls { get; set; }
        public int TotalRoll { get; set; }
    }
}
