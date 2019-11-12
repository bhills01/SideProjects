using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    public class DDCharacter
    {
        public DDCharacter()
        {
            ExpPoint = 0;
            Level = 1;
        }

        [StringLength(15, MinimumLength = 1)]
        public string CharacterName { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public string Background { get; set; }
        [StringLength(15, MinimumLength = 1)]

        public string PlayerName { get; set; }
        public string Race { get; set; }
        public string Alignment { get; set; }
        public int ExpPoint { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }







    }
}
