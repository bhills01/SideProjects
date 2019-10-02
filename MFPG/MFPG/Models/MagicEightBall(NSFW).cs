using System;
using System.Collections.Generic;
using System.Text;

namespace MFPG.Models
{
    public class MagicEightBall_NSFW_
    {
        private string[] answersNSFW = new string[]
        {
            "Ask your sister...oh wait, she said no",
            "Ask your mother...oh wait, she said no",
            "(Uncontrollable sobbing) Ask again later. I can’t…I just can’t deal with this right now.",



            //Add new Flambini answers above this line
        };
        public void magicEightBallNSFW()
        {
            Random randomNum = new Random();

            Console.Clear();
            Console.Write("Ask me any yes or no question and I will tell your future!: ");
            Console.ReadLine();
            Console.WriteLine($"\nI have consorted with the spirits to divine your future! Here is your answer: {answersNSFW[randomNum.Next(0, answersNSFW.Length)]}");
            Console.WriteLine("\nPress enter to continue for next task");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("************************************************************************************************************************");
        }
    }
}
