using System;
using System.Threading;
using MFPG.Models;
using System.IO;
using System.Linq;

namespace MFPG
{
    class Program
    {

        static void Main(string[] args)
        {
            // Code to make a menu for a user interface (working with classes and stuff like that)
            bool visible = true;
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < 16; i++)
            {
                //Press Ctrl + C to Quit
                string alert = "****************************************************************************************************************************************************************************" +
                    "\n****************************************************************************************************************************************************************************" +
                    "\n****************************************************************************************************************************************************************************" +
                    "\n\t\t\t\tWho dare disturb the Great Flambini All Powerful and Majestic Mystic of the Futuuuuurrrreeeee!!!!";
                Console.ForegroundColor = visible ? ConsoleColor.White : ConsoleColor.DarkRed;
                visible = !visible;
                Console.Clear();
                Console.WriteLine(alert);
                Console.ForegroundColor = ConsoleColor.Black;
                Thread.Sleep(300);
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Directory.SetCurrentDirectory(@"../../..");
            Console.WriteLine();
            string inputLine = "";
            using (StreamReader sr = new StreamReader("flambiniface.txt"))
            {
                while (!sr.EndOfStream)
                {
                    inputLine = sr.ReadLine();
                    Console.WriteLine($"\t\t\t\t\t\t  {inputLine}");
                }
            }
            Console.WriteLine("\t\t\t\t\t\t\tPress [ENTER] to enter into my mystical domain");
            Console.ReadLine();
            Console.Clear();
            bool menu = true;
            string Progresbar = "The Mystical All Powerful Flambini";
            var title = "";
            for (int i = 0; i < Progresbar.Length; i++)
            {
                title += Progresbar[i];
                Console.Title = title;
                Thread.Sleep(100);
            }
            title = "";
            while (menu == true)
            {
                Console.WriteLine("****************************************************************************************************************************************************************************");
                Console.WriteLine("\n****************************************************************************************************************************************************************************");
                Console.WriteLine("\n****************************************************************************************************************************************************************************");
                Console.Write(
                    "\t\t\t\t\t\t\t1) Fortune Teller" +
                    "\n\t\t\t\t\t\t\t2) Magic 8-Ball (SFW)" +
                    "\n\t\t\t\t\t\t\t3) Magic 8-Ball (NSFW)" +
                    "\n\t\t\t\t\t\t\t4) Riddle Giver" +
                    "\n\t\t\t\t\t\t\t5) Rock Paper Scissors" +
                    "\n\t\t\t\t\t\t\t6) Random Fact Giver" +
                    "\n\t\t\t\t\t\t\t7) Paper Rock Scissors" +
                    "\n\t\t\t\t\t\t\tQ) Quit" +
                    "\n\n\n\t\t\t\t\t\t\tPlease choose an option: ");
                String input = Console.ReadLine().ToLower().Trim();

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
                    menu = false;
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
                else if (input == "5")
                {
                    RockPaperScissors rps = new RockPaperScissors();
                    rps.RPS();
                }
                else if (input == "6")
                {
                    RandomFactGiver fact = new RandomFactGiver();
                    fact.factGiver();
                }
                else if (input == "7")
                {
                    RageInducingRockPaperScissors rps = new RageInducingRockPaperScissors();
                    rps.RIRPS();
                }
                else
                {
                    Console.Clear();

                    continue;
                }


                }
            Console.Clear();
            string credit = "\t\t\tThe Great Flambini is brought to you by a collaborative effort from the following Tech Elevator Cohort 12 .NET Members:\n\n\t\t\t\t\t Brandon \"Intellesense\" Best \n\t\t\t\t\t Glenn \"The Builder\" Weber \n\t\t\t\t\t Bradley \"Big Papa\" Hills \n\t\t\t\t\t Reid \"The Golden Steed\" Larson \n\t\t\t\t\t Will \"Swift Squirrel\" Schneider \n\t\t\t\t\t With a Special Thanks to  \"Magic\" Mike Morel for filling our brains with magic! \n\t\t\t\t\t Thank you for visiting the Great Flambini\n\n\n\t\t\t\t\t Press [ENTER] to exit the Flambini";
            var Title = "";
            for (int i = 0; i < credit.Length; i++)
            {
                Title = credit[i] + "";
                Console.Write($"{Title}");
                Thread.Sleep(25);
            }
            Console.ReadLine();
            //Console.Clear();
            //Credits firstCredits = new Credits();
            //Console.WriteLine($"{firstCredits.Contributers()}");
            //Console.WriteLine();
            //Console.WriteLine("\t\t\t Press [Enter] to exit the Great Flambini");
            //Console.ReadLine();
        }
    }
}



