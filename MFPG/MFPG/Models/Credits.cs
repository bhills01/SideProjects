using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MFPG.Models
{
    public class Credits
    {
        public string Contributers()
        {
            string Progresbar = "The People Who Made This Program";
            var title = "";
            for (int i = 0; i < Progresbar.Length; i++)
            {
                title += Progresbar[i];
                Console.Title = title;
                Thread.Sleep(100);
            }
            return "****************************************************************************************************************************************************************************" +
                    "\n****************************************************************************************************************************************************************************" +
                    "\n****************************************************************************************************************************************************************************" +
                   "\n\t\t\t The Great Flambini is brought to you by a collaborative effort from the following Tech Elevator Cohort 12 .NET Members: " +
                   "\n\t\t\t Brandon \"Intellesense\" Best" +
                   "\n\t\t\t Glenn \"The Builder\" Weber" +
                   "\n\t\t\t Bradley \"Big Papa\" Hills" +
                   "\n\t\t\t Reid \"The Golden Steed\" Larson" +
                   "\n\t\t\t Will \"Swift Squirrel\" Schneider" +
                   "\n\t\t\t With a Special Thanks to  \"Magic\" Mike Morel for filling our brains with magic!" +
                   "\n\t\t\t Thank you for visiting the Great Flambini";
        }
    }
}
