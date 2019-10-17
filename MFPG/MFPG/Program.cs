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
            Console.BackgroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < 16; i++)
            {
                //Press Ctrl + C to Quit
                string alert = "****************************************************************************************************************************************************************************" +
                    "\n****************************************************************************************************************************************************************************" +
                    "\n****************************************************************************************************************************************************************************" +
                    "\n\t\t\t\tWho dare disturb the Great Flambini All Powerful and Majestic Mystic of the Futuuuuurrrreeeee!!!!";
                Console.ForegroundColor = visible ? ConsoleColor.White: ConsoleColor.Black;
                visible = !visible;
                Console.Clear();
                Console.WriteLine(alert);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(300);
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Directory.SetCurrentDirectory(@"../../..");
            Console.WriteLine();
            string inputLine = "";
            using (StreamReader sr = new StreamReader("flambiniface.txt"))
            {
                while (!sr.EndOfStream)
                {
                    inputLine = sr.ReadLine();
                    Console.WriteLine($"\t\t\t\t\t  {inputLine}");
                }
            }
            Console.ReadLine();
            Console.Clear();
                        bool menu = true;

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
                        Credits firstCredits = new Credits();
                        Console.WriteLine($"{firstCredits.Contributers()}");
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t Press [Enter] to exit the Great Flambini");
                        Console.ReadLine();
                    }
    }
}


