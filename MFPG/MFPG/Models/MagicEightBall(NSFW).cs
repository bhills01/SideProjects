using System;
using System.Collections.Generic;
using System.Text;

namespace MFPG.Models
{
    public class MagicEightBall_NSFW_
    {
        private string[] answersNSFW = new string[]
        {
            "Ask your sister...No wait, I will. She said no.",
            "Ask your mother...Hold on, I will. She said as soon as she's done servicing me she'll let you know.",
            "(Uncontrollable sobbing) Ask again later. I can’t…I just can’t deal with this right now.",
            "FUCK NO!!!",
            "Sure, why not?",
            "Yep",
            "I don't see why not",
            "Nah son!",
            "You kiss your mother with that mouth, Fuck off",
            "Nope",
            "Not today....maybe some other time",
            "As surely as your girlfriend's womb is a barren wasteland never to spawn you an heir...oh you didn't know? Sorry.",
            "Watch the entire series of Spartacus on Netflix then if you don't have your answer...ask me again.",



            //Add new Flambini answers above this line
        };
        public void magicEightBallNSFW()
        {
            Random randomNum = new Random();
            bool anotherQuestion = true;
            string input = "";

            while (anotherQuestion)
            {
                Console.Clear();
                Console.Write("Ask me any yes or no question and I will tell your future!: ");
                Console.ReadLine();
                Console.WriteLine($"\nI have consorted with the spirits to divine your future! Here is your answer: {answersNSFW[randomNum.Next(0, answersNSFW.Length)]}");
                Console.WriteLine("\nWould you like to ask another question? (Y)es or (N)o:");
                input = Console.ReadLine().ToLower();
                Console.Clear();

                Console.Clear();
                Console.WriteLine("************************************************************************************************************************");
                Console.WriteLine("************************************************************************************************************************");
                Console.WriteLine("************************************************************************************************************************");
            }
        }
    }
}
