using System;
using System.Collections.Generic;
using System.Text;

namespace MFPG.Models
{
    public class RandomFactGiver
    {
        private string[] facts = new string[]
        {
            "Canadians say \"Sorry\" so much that a law was passed in 2009 declaring that an apology can't be used as evidence of admission to guilt",
            "The average person will spend six months of their life waiting for red lights to turn green",
            "Cherophobia is the word for the irrational fear of being happy",
            "A bolt of lightning contains enough energy to toast 100,000 slices of bread",
            "Subway footlongs aren’t a foot long.",
            "One in three divorce filings include the word \"Facebook.\"",
            "The Netherlands is so safe, it imports criminals to fill jails.",
            "The world’s largest pyramid isn’t in Egypt.",
            "Tons and tons and tons of countries celebrate their independence from the U.K.",
            "The most requested funeral song in England is by Monty Python.",
            "Rich Russians hire fake ambulances.",
            "A California woman tried to sue the makers of Cap’N’Crunch after she learned Crunch Berries were not real berries",
            "Apple briefly had its own clothing and lifestyle line in 1986",
        };
        public void factGiver()
        {
            Random randomNum = new Random();
            bool anotherQuestion = true;
            string input = "";
            while (anotherQuestion)
            {
                Console.Clear();
                Console.Write("Press enter to recieve your random fact! ");
                Console.ReadLine();
                Console.WriteLine($"\nFrom my vast amout of knowledge, here is your random fact: {facts[randomNum.Next(0, facts.Length)]}");
                Console.WriteLine("\nPress enter to continue for next task");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Would you like to recieve another fact? (Y)es or (N)o:");
                bool anotherOne = true;
                while (anotherOne)
                {
                    input = Console.ReadLine().ToLower();
                    if (input == "y")
                    {
                        anotherQuestion = true;
                        break;
                    }
                    if (input == "yes")
                    {
                        anotherQuestion = true;
                        break;
                    }
                    if (input == "n")
                    {
                        anotherQuestion = false;
                        break;
                    }
                    if (input == "no")
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
            Console.WriteLine("****************************************************************************************************************************************************************************");
            Console.WriteLine("\n****************************************************************************************************************************************************************************");
            Console.WriteLine("\n****************************************************************************************************************************************************************************");
        }


    }
}

