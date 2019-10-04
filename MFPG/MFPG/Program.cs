using System;
using System.Threading;
using MFPG.Models;
using ReadCountryData;

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
            //GreatFlambini greatFlambini = new GreatFlambini();

            //greatFlambini.RunFlambini();

            //Text typing out on top of the console window
            //string Progresbar = "The Great Flambini All Powerful and Majestic Mystic of the Futuuuuurrrreeeee!!!!";
            //var title = "";
            //while (true)
            //{
            //    for (int i = 0; i < Progresbar.Length; i++)
            //    {
            //        title += Progresbar[i];
            //        Console.Title = title;
            //        Thread.Sleep(100);
            //    }
            //    title = "";
            //}
            // Code to make a menu for a user interface (working with classes and stuff like that)
            bool visible = true;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < 16; i++)
            {
                //Press Ctrl + C to Quit
                string alert = "************************************************************************************************************************" +
                    "\n************************************************************************************************************************" +
                    "\n************************************************************************************************************************" +
                    "\n\tWho dare disturb the Great Flambini All Powerful and Majestic Mystic of the Futuuuuurrrreeeee!!!!";
                Console.ForegroundColor = visible ? ConsoleColor.White: ConsoleColor.Black;
                visible = !visible;
                Console.Clear();
                Console.WriteLine(alert);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(300);
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("************************************************************************************************************************");
                Console.WriteLine("\n************************************************************************************************************************");
                Console.WriteLine("\n************************************************************************************************************************");
                Console.Write("\t\t\t\t1) Fortune Teller\n\t\t\t\t2) Magic 8-Ball (SFW)\n\t\t\t\t3) Magic 8-Ball (NSFW)\n\t\t\t\t4) Riddle Giver\n\t\t\t\tQ) Quit\n\n\n\t\t\t\tPlease choose an option: ");
                String input = Console.ReadLine().ToLower();

                if (input.Length == 0)
                {
                    Console.Clear();
                    continue;

                }
                if (input.Length > 1)
                {
                    Console.Clear();
                    continue;

                }
                input = input.Substring(0, 1);

                if (input == "q")
                {
                    break;
                }
                else if (input == "1")
                {
                    FortuneTeller fortuneTeller = new FortuneTeller();
 
                    fortuneTeller.fortuneTeller();
                }
                else if (input == "2")
                {
                    MagicEightBall_SFW_ magicEightBallSFW = new MagicEightBall_SFW_();
 
                    magicEightBallSFW.magicEightBallSFW();
                }
                else if (input == "3")
                {
                    MagicEightBall_NSFW_ magicEightBallNSFW = new MagicEightBall_NSFW_();

                    magicEightBallNSFW.magicEightBallNSFW();

                }
                else if (input == "4")
                {
                    Riddles riddle = new Riddles();

                    riddle.riddleGiver();

                }
                else
                {
                    Console.Clear();
                    //Console.WriteLine("************************************************************************************************************************");
                    //Console.WriteLine("\n************************************************************************************************************************");
                    //Console.WriteLine("\n************************************************************************************************************************");
                    //Console.Write("\n\t\t\t\t1) Fortune Teller\n\t\t\t\t2) Magic 8-Ball (SFW)\n\t\t\t\t3) Magic 8-Ball (NSFW)\n\t\t\t\t4) Riddle Giver\n\t\t\t\tQ) Quit\n\n\n\t\t\t\tPlease choose an option: ");
                    continue;
                }


            }
        }
    }
}


