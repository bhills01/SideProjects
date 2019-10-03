using System;
using System.Collections.Generic;
using System.Text;

namespace MFPG.Models
{
    public class FortuneTeller
    {
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
        public void fortuneTeller()
        {
            Random randomNum = new Random();
            bool anotherQuestion = true;
            string input = "";
            while (anotherQuestion)
            {
                Console.Clear();
                Console.Write("Press enter for your fortune! ");
                Console.ReadLine();
                Console.WriteLine($"\nI have consorted with the spirits to divine your future! Here is your fortune: {fortunes[randomNum.Next(0, fortunes.Length)]}");
                Console.WriteLine("\nPress enter to continue for next task");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Would you like to recieve another fortune? (Y)es or (N)o:");
                bool anotherOne = true;
                while (anotherOne)
                {
                    input = Console.ReadLine().ToLower();
                    if (input == "y")
                    {
                        anotherQuestion = true;
                        break;
                    }
                    if (input == "n")
                    {
                        anotherQuestion = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter either Y or N");
                        continue;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("************************************************************************************************************************");
        }


    }
}
