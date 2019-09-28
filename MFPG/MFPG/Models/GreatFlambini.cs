using System;
using System.Collections.Generic;
using System.Text;

namespace MFPG.Models
{
    class GreatFlambini
    {
        public string[] answers = new string[] { "Yes", "No", "Maybe", "Ask again Later", "Does not seem likely", "You can count on it!" };
        public string[] fortunes = new string[]
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

        public void GreatFlambiniIntro()
        {
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("Who dare disturb the Great Flambini All Powerful and Majestic Mystic of the Futuuuuurrrreeeee!!!!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Well, since you have my attention... Would you like to consult the (M)agic Eight Ball, or receive your (F)ortune?");
        }

        public void MagicEightBall()
        {
            Random randomNum = new Random();

            Console.WriteLine("Ask me any yes or no question and I will tell your future!: ");
            Console.Write("Ask me any yes or no question and I will tell your future!: "); Console.Read();
            Console.WriteLine();
            Console.WriteLine($"I have consorted with the spirits to divine your future! Here is your answer: {answers[randomNum.Next(0, 5)]}");
            Console.ReadLine();
        }

        public void FortuneTeller()
        {
            Random randomNum = new Random();

            Console.WriteLine("Type enter for your fortune!: ");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"I have consorted with the spirits to divine your future! Here is your fortune: {fortunes[randomNum.Next(0, 13)]}");
            Console.ReadLine();
        }
    }
}
