using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFPG.Models
{
    public class NumberGuesser
    {
        public void numberGuesser()
        {
            Random rnd = new Random();
            int flambiniNumber = rnd.Next(1,10);
            Console.WriteLine("Please guess a number.");
            string userInput = Console.ReadLine();
            if (userInput == flambiniNumber.ToString())
            {
                Console.WriteLine("Congrats, you guessed my number. Press [ENTER] to continue");
                Console.ReadLine();

            }
            if (userInput != flambiniNumber.ToString())
            {
                Console.WriteLine("Incorrect, guess again");
            }
        }
    }
}
    
        
    
