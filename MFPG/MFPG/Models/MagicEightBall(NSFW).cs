﻿using System;
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
            "Ask your sister...oh wait, she said yes...to me",
            "Ask your mother...oh wait, she said yes...to me",

            //Add new Flambini answers above this line
        };
        public void magicEightBallNSFW()
        {
            Random randomNum = new Random();

            Console.Clear();
            Console.Write("Ask me any yes or no question and I will tell your future!: "); Console.Read();
            Console.WriteLine();
            Console.WriteLine($"I have consorted with the spirits to divine your future! Here is your answer: {answersNSFW[randomNum.Next(0, answersNSFW.Length)]}");
            Console.ReadLine();
            Console.WriteLine("\n\nPress enter to continue for next task");
            Console.ReadKey();
        }
    }
}
