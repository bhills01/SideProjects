using System;
using System.Collections.Generic;
using System.Text;

namespace MFPG.Models
{
    class GreatFlambini
    {
        // array list of possible answers to yes/no questions
        // removed string array cap, to add additional Flambini answers simply add a new string - 9/30
        private string[] answers = new string[] 
        {
            "Yes",
            "No",
            "Maybe",
            "Ask again Later",
            "Ask your mom, no wait, I will.....she says no!",
            "Does not seem likely",
            "You can count on it!",

            //Add new Flambini answers above this line
        };

        // array list of possible fortunes to tell the user
        // removed string array cap, to add additional Flambini fotunes simply add a new string - 9/30
        private string[] fortunes = new string[]
        {
            "A beautiful, smart, and loving person will be coming into your life.",
            "A dubious friend may be an enemy in camouflage.",
            "A faithful friend is a strong defense.",
            "A feather in the hand is better than a bird in the air.",
            "A fresh start will put you on your way.",
            "A friend asks only for your time not your money.",
            "A friend is a present you give yourself.",
            "A gambler not only will lose what he has, but also will lose what he doesn’t have.",
            "A golden egg of opportunity falls into your lap this month.",
            "A good friendship is often more important than a passionate romance.",
            "A good time to finish up old tasks.",
            "A hunch is creativity trying to tell you something.",
            "A lifetime friend shall soon be made.",
            "A lifetime of happiness lies ahead of you."
        };

        // introduces the great flambini and asks user which fortune path they want to take
        private string greatFlambiniIntro()
        {
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("Who dare disturb the Great Flambini All Powerful and Majestic Mystic of the Futuuuuurrrreeeee!!!!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Well, since you have my attention... Would you like to consult the (M)agic Eight Ball, or receive your (F)ortune?");

            return Console.ReadLine().ToString();
        }

        // magic 8 ball fortune path
        private void magicEightBall()
        {
            Random randomNum = new Random();

            Console.Clear();
            Console.Write("Ask me any yes or no question and I will tell your future!: "); Console.Read();
            Console.WriteLine();
            Console.WriteLine($"I have consorted with the spirits to divine your future! Here is your answer: {answers[randomNum.Next(0, answers.Length)]}");
            Console.ReadLine();
        }

        // fortune teller fortune path
        private void fortuneTeller()
        {
            Random randomNum = new Random();

            Console.Clear();
            Console.WriteLine("Type enter for your fortune!: ");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"I have consorted with the spirits to divine your future! Here is your fortune: {fortunes[randomNum.Next(0, fortunes.Length)]}");
            Console.ReadLine();
        }

        public void RunFlambini()
        {
            bool continueFlambini = true;

            string fortunePath = greatFlambiniIntro();

            while (continueFlambini)
            {
                if (fortunePath.ToLower() == "m")
                {
                    magicEightBall();
                }
                else if (fortunePath.ToLower() == "f")
                {
                    fortuneTeller();
                }
                else
                {
                    Console.WriteLine("Improper entry.");
                }

                Console.WriteLine();
                Console.Write("Would you like another fortune? (y or n): ");
                string userContineChoice = Console.ReadLine();

                if (userContineChoice.ToLower() == "y")
                {
                    continueFlambini = true;
                }
                else
                {
                    continueFlambini = false;
                }
            }
            Console.Clear();
            Console.WriteLine("Okay goodbye! Press enter to exit the console. ");
            Console.ReadKey();
        }
    }
}
