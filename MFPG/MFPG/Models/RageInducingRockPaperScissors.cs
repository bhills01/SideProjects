using System;
using System.Collections.Generic;
using System.Text;

namespace MFPG.Models
{
    public class RageInducingRockPaperScissors
    {
        public void RIRPS()
        {
            Random rnd = new Random();
            string flambiniVoice = "";
            string[] rps = new string[] { "r", "p", "s" };
            bool playAgain = true;
            int flambiniScore = 0;
            int userScore = 0;
            while (playAgain)
            {
                while ((userScore < 2) && (flambiniScore < 2))
                {

                    string flambiniInput = rps[rnd.Next(0, 3)];
                    Console.Clear();
                    Console.Write($"Select (R)ock, (P)aper, (S)cissors: ");
                    string userInput = Console.ReadLine().ToLower().Trim();
                    if (userInput == "r")
                    {
                        flambiniInput = rps[2];
                        Console.WriteLine($"Flambini chooses Scissors");
                        flambiniVoice = "Hmmm, you got one past me. It will not happen again!";
                        userScore++;
                    }
                    else if (userInput == "s")
                    {
                        flambiniInput = rps[1];
                        Console.WriteLine($"Flambini chooses Paper!");
                        flambiniVoice = "You watch yourself clever one...";
                        userScore++;
                        
                    }
                    else if (userInput == "p")
                    {
                        flambiniInput = rps[0];
                        Console.WriteLine($"Flambini chooses Rock!");
                        flambiniVoice = "Fuck your mother!!";
                        userScore++; 
                    }
                    else
                    {
                        flambiniVoice = "That was not one of the options, try again smart ass.";
                    }
                    Console.WriteLine(flambiniVoice);
                    Console.WriteLine($"Your current score is: {userScore}, and Flambini's is: {flambiniScore}");
                    Console.WriteLine("Press [ENTER] for the next round.");
                    Console.ReadLine();

                }
                while ((userScore < 3) && (flambiniScore < 3))
                {
                    string flambiniInput = "";
                    Console.Clear();
                    Console.Write($"Select (R)ock, (P)aper, (S)cissors: ");
                    string userInput = Console.ReadLine().ToLower().Trim();
                    if (userInput == "r")
                    {
                        flambiniInput = rps[1];
                        Console.WriteLine($"Flambini chooses Paper!");
                        flambiniVoice = "You suck at this entire game. Paper beats Rock!";
                        flambiniScore++;
                    }
                    else if (userInput == "s")
                    {
                        flambiniInput = rps[0];
                        Console.WriteLine($"Flambini chooses Rock!");
                        flambiniVoice = "Pathetic attempt loser. Rock beats Scissors!";
                        flambiniScore++;
                    }
                    else if (userInput == "p")
                    {
                        flambiniInput = rps[2];
                        Console.WriteLine($"Flambini chooses Scissors");
                        flambiniVoice = "Ha!You should just give up now. Scissors beats Paper!";
                        flambiniScore++;
                    }
                    Console.WriteLine(flambiniVoice);
                    Console.WriteLine($"Your current score is: {userScore}, and Flambini's is: {flambiniScore}");
                    Console.WriteLine("Press [ENTER] for the next round.");
                    Console.ReadLine();
                }
                Console.Clear();
                string resultsText;
                if (userScore > flambiniScore)
                {
                    resultsText = "You win....now get your ass out of here!!";
                }
                else
                {
                    resultsText = "SUCK IT!!!!";
                }

                Console.WriteLine(resultsText);
                Console.WriteLine();
                Console.Write("Press [ENTER] to exit to the menu or (A)gain to play again: ");
                string userAnswer = Console.ReadLine().ToLower().Trim();
                if (userAnswer == "a")
                {
                    flambiniScore = 0;
                    userScore = 0;
                    playAgain = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("************************************************************************************************************************");
                    Console.WriteLine("************************************************************************************************************************");
                    Console.WriteLine("************************************************************************************************************************");
                    break;
                }

            }
        }
    }
}
    

