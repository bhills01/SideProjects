using System;
using MFPG.Models;

namespace MFPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random randomNum = new Random();
            //string[] answer = new string[] { "Yes", "No", "Maybe", "Ask again Later", "Does not seem likely", "You can count on it!" };
            //string yesOrNo = "";

            //Console.WriteLine("*************************************************************************************************");
            //Console.WriteLine("*************************************************************************************************");
            //Console.WriteLine("*************************************************************************************************");
            //Console.WriteLine("Who dare disturb the Great Flambini All Powerful and Majestic Mystic of the Futuuuuurrrreeeee!!!!");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.Write("Well, since you have my attention...Ask me any yes or no question and I will tell your future!: "); Console.Read();
            //Console.WriteLine();
            //Console.WriteLine($"I have consorted with the spirits to divine your future! Here is your answer: {answer[randomNum.Next(0, 5)]}");
            //Console.ReadLine();

            //Console.Write("Would you like to ask another question(y)es or (n)o? ");

            //yesOrNo = Console.ReadLine();

            //while (yesOrNo != "n")
            //{
            //    Console.WriteLine("*************************************************************************************************");
            //    Console.WriteLine("*************************************************************************************************");
            //    Console.WriteLine("*************************************************************************************************");
            //    Console.Write("Fine...What is your questions? "); Console.Read();
            //    Console.WriteLine();
            //    Console.WriteLine($"I have consorted with the spirits to divine your future! Here is your answer: {answer[randomNum.Next(0, 5)]}");
            //    Console.ReadLine();

            //    Console.Write("Would you like to ask another question(y)es or (n)o? ");

            //    yesOrNo = Console.ReadLine();
            //}

            //Console.WriteLine("Thank god!!! Off with you then!");
            //Console.WriteLine("Tap (enter) to return to your boring life!");
            //Console.ReadLine();




            //// comment out the code above and uncomment the 2 lines of code below to run my GreatFlambini class functionality ~Brandon
            GreatFlambini greatFlambini = new GreatFlambini();

            greatFlambini.RunFlambini();
        }
    }
}
