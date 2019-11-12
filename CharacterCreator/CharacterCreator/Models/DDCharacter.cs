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
        }

        [StringLength(15, MinimumLength = 1)]
        public string CharacterName { get; set; }
        public string Class { get; set; }
        public string Background { get; set; }
        [StringLength(15, MinimumLength = 1)]

        public string PlayerName { get; set; }
        public string Race { get; set; }
        public string Alignment { get; set; }
        public int ExpPoint { get; set; }







    }
}
