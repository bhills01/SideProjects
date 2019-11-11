using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    public class CharCreatorVM
    {
        public CharCreatorVM()
        {

        }
        public CharCreatorVM(string gameUniverse)
        {
            gameUniverse = GameUniverse;
        }
        public string GameUniverse { get; set; }
    }
}
