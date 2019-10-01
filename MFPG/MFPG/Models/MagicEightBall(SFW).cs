using System;
using System.Collections.Generic;
using System.Text;

namespace MFPG.Models
{
    public class MagicEightBall_SFW_
    {
        private string[] answersSFW = new string[]
        {
            "Yes",
            "Outlook good",
            "Yes - definitely",
            "Most likely",
            "As I see it, yes",
            "You may rely on it",
            "Without a doubt",
            "It is certain",
            "It is decidedly so",
            "Reply hazy, try again",
            "Ask again later",
            "Cannot predict now",
            "Better not tell you now",
            "Concentrate and ask again",
            "Don't count on it",
            "My reply is no",
            "My sources say no",
            "Outlook not so good",
            "Very doubtful",

            //Add new Flambini answers above this line
        };
        public void magicEightBallSFW()
        {
            Random randomNum = new Random();

            Console.Clear();
            Console.Write("Ask me any yes or no question and I will tell your future!: ");
            Console.Read();
            Console.WriteLine();
            Console.WriteLine($"I have consorted with the spirits to divine your future! Here is your answer: {answersSFW[randomNum.Next(0, answersSFW.Length)]}");
            Console.ReadLine();
            Console.WriteLine("\n\nPress enter to continue for next task");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("************************************************************************************************************************");
        }
    }
}
