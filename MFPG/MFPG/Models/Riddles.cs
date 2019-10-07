using System;
using System.Collections.Generic;
using System.Text;

namespace MFPG.Models
{
    class Riddles
    {
        private Dictionary<string, string> riddleSet = new Dictionary<string, string>()
        {
            {"What has to be broken before it can be used?","egg"},
            {"Jimmy’s mother had three children. The first was called April, the second was called May. What was the name of the third?","jimmy"},
            {"What begins with T, ends with T, and has T in it?","teapot"},
            {"What has a head and a tail but no body?","coin"},
            {"What building has the most stories?","library"},
            {"You throw away the outside, eat the inside, then throw away the inside. What is it?","corn"},
            {"What can never be put in a saucepan?","lid"},
            {"I speak without a mouth and hear without ears. I have no body, but I come alive with wind. What am I?","echo" },
            {"You measure my life in hours and I serve you by expiring. I’m quick when I’m thin and slow when I’m fat. The wind is my enemy.","candle" },
            {"I have cities, but no houses. I have mountains, but no trees. I have water, but no fish. What am I?","map" },
            {"What is seen in the middle of March and April that can’t be seen at the beginning or end of either month?","r" },
            {"You see a boat filled with people. It has not sunk, but when you look again you don’t see a single person on the boat. Why?","married" },
            {"What word in the English language does the following: the first two letters signify a male, the first three letters signify a female, the first four letters signify a great, while the entire world signifies a great woman. What is the word?","heroine" },
            {"What English word has three consecutive double letters?","bookkeeper" },
            {"A woman shoots her husband, then holds him underwater for five minutes. Next, she hangs him. Right after, they enjoy a lovely dinner. Explain.","picture" },
            {"I come from a mine and get surrounded by wood, or plastic, always. Everyone uses me. What am I?","pencil lead" },
            {"A girl has as many brothers as sisters, but each brother has only half as many brothers as sisters. How many brothers and sistes are there in the family?","four sisters three brothers." },
            {"What disappears as soon as you say its name?","silence" },
            {"How can the number four be half of five?","iv" },
            {"I have keys, but no locks and space, and no rooms. You can enter, but you can’t go outside. What am I?","keyboard" },
            {"What gets wet while drying?","towel" },
            {"How many letters are in the alphabet?","11"},
            {"What are the next three letters in this combination? OTTFFSS","ent" },
            {"This belongs to you, but everyone else uses it.","name" },
            {"(read and answer as soon as you are done reading) First, think of the color of the clouds. Next, think of the color of snow. Now, think of the color of a bright full moon. Now answer quickly what do cows drink?","water" },
            {"How is seven different from the rest of the numbers between one and ten?","two syllables" },
            {"First you eat me, then you get eaten. What am I?","fishhook" },
            {"What comes once in a minute, twice in a moment, but never in a thousand years?","m" },
            {"Which word in the dictionary is always spelled incorrectly?","incorrectly" },
            {"What can you hold in your right hand, but never in your left hand?","left elbow" },
            {"How can you physically stand behind your father while he is standing behind you?","back-to-back father" },

        };
        public void riddleGiver()
        {
            
            bool anotherQuestion = true;
            
            while (anotherQuestion)
            {
                Random randomNum = new Random();
                List<string> riddles = new List<string>(riddleSet.Keys);
                int number = randomNum.Next(riddles.Count);
                string input = "";
                Console.Clear();
                Console.WriteLine("Press enter for your riddle! ");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine($"Here is your riddle to solve: {riddles[number]}");
                Console.Write("Please enter your answer: ");
                string userAnswer = Console.ReadLine().ToLower();
                //if (riddleSet[riddles[number]].ToLower().Contains(userAnswer))
                if (userAnswer.Contains(riddleSet[riddles[number]].ToLower()))
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine($"You're so stupid. The answer to your riddle is: {riddleSet[riddles[number]]}");
                }
                riddleSet.Remove(riddles[number]);
                if (riddleSet.Count == 0)
                {
                    Console.WriteLine("\nOut of riddles. Come back again later. Press enter to return to the menu");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine("\nPress enter for next task");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Would you like to recieve another riddle? (Y)es or (N)o:");
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
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("************************************************************************************************************************");
        }
    }
}
