using System;
using System.Drawing;
using Console = Colorful.Console;
using BitcoinBusinessLayer;

namespace ConsoleApp1
{
    public class Instructions
    {   
        public static void printInstructions(string name, int totalDays, float totalBitcoin)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.Write(name + ",", Color.Red);
            Console.Write(" you have " + totalDays + " days to make the most money possible via trading bitcoins.");
            Console.WriteLine("");
            Console.WriteLine("When there are no more days left, your final score will equal the following: [total money + bitcoin assets]");
            Console.WriteLine("You will start out with " + totalBitcoin + " bitcoins.");
            Console.WriteLine("");

        }

    }
}