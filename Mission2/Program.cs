using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Matt Curzon January 18 2023

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            // intro text
            Console.WriteLine("Welcome to the dice rolling simulator!");
            Console.WriteLine("How many dice would you like to simulate? ");
            int totalDice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS: ");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls");
            Console.WriteLine("Total amount of rolls: " + totalDice);


            int[] rollResults = new int[11];

            Random rnd = new Random();

            // simulate 2 die that roll numbers between 1 and 6, add the two rolls and save a count for each number
            for (int i = 0; i < totalDice; i++)
            {
                int roll1 = 0;
                int roll2 = 0;
                roll1 = rnd.Next(6) + 1;
                roll2 = rnd.Next(6) + 1;

                int totalRolled = roll1 + roll2;

                rollResults[totalRolled - 2]++;
            }

            // outout results
            for (int i = 0; i < rollResults.Length; i++)
            {
                // create a string of astrics that represent 1 percent of total number
                int totalAstrics = 0;

                totalAstrics = (rollResults[i] * 100) / totalDice;

                string astricString = "";

                for (int j = 0; j < totalAstrics; j++)
                {
                    astricString = astricString + "*";
                }

                Console.WriteLine((i + 2) + ": " + astricString);

            }
        }
    }
}
