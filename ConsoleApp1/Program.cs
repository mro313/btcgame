using System;
using System.Drawing;
using Console = Colorful.Console;
using BitcoinBusinessLayer;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            ServiceCalculationBusinessLayer bitcoinBusinessLayer = new ServiceCalculationBusinessLayer();
            bitcoinBusinessLayer.CalculateBitcoinServiceFee(3);

            // Global variables
            float totalBitcoin = 1.0F;
            float totalMoney = 0F;

            //moved this from loop, to global variable
            int currentDay = 1;

            //move these from local, to global variable to be used later
            int daysLeft = 0;
            int btcPrice = 0;

            // create Random class (system class)
            Random generateRandom = new Random();

            // get player nanme
            Console.WriteLine("Enter your name: ", Color.LimeGreen);
            string name = Console.ReadLine();
            Console.Clear();

            // ask for game length
            Console.Clear();
            Console.WriteLine("How many days do you want to trade bitcoin?", Color.LimeGreen);
            int totalDays = Convert.ToInt32(Console.ReadLine());

            // player instructions
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.Write(name + ",", Color.Red); 
            Console.Write(" you have " + totalDays + " days to make the most money possible via trading bitcoins.");
            Console.WriteLine("");
            Console.WriteLine("When there are no more days left, your final score will equal the following: [total money + bitcoin assets]");
            Console.WriteLine("You will start out with " + totalBitcoin + " bitcoins.");
            Console.WriteLine("");


            for (int i = 1; currentDay <= totalDays; currentDay++)
            {
                // local variables
                daysLeft = totalDays - currentDay;
                btcPrice = generateRandom.Next(0, 70000); // daily bitcoin price
                string input = "";

                
                
                while (input != "done")
                {
                    // prompt - menu
                    Console.WriteLine("-------------------------------------------------------------- ");
                    Console.WriteLine("Today is day " + currentDay + ". You have " + daysLeft + " days left.", Color.Red);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Current bitcoin price is: ");
                    Console.WriteLine("$" + btcPrice, Color.LimeGreen);
                    Console.WriteLine("You have " + totalBitcoin + " bitcoins.");
                    Console.WriteLine("You have $" + totalMoney + " dollars.");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("What do you want to do?", Color.LimeGreen);
                    Console.WriteLine("   // type 'buy' to buy bitcoins");
                    Console.WriteLine("   // type 'sell' to sell your bitcoins");
                    Console.WriteLine("   // type 'done' if you are done trading for the day");
                    Console.WriteLine("-------------------------------------------------------------- ");


                    // switch statement
                    input = Console.ReadLine().ToLower();

                    switch (input)
                    {

                        case "sell":
                            // creating an instance of the SellClass 
                            var sellBitcoinObject = new SellClass();

                            // now you can call the method on that instance
                            var sellTradeResult = sellBitcoinObject.SellBitcoin(totalBitcoin, totalMoney, btcPrice);

                            if (sellTradeResult != null)
                            {
                                // need to update the global variables
                                totalBitcoin = sellTradeResult.TotalBitcoin;
                                    totalMoney = sellTradeResult.TotalMoney;
                            }
                            break;

                        case "buy":
                            var buyBitcoinObject = new BuyClass();
                            // in order to call a method on the instance...need to:
                            // ** you don't need to refer to the class... only the instance!"
                            var buyTradeResult = buyBitcoinObject.BuyBitcoin(totalBitcoin, totalMoney, btcPrice);

                            if (buyTradeResult != null)
                            {
                                // need to update the global variables
                                totalBitcoin = buyTradeResult.TotalBitcoin;
                                totalMoney = buyTradeResult.TotalMoney;
                            }
                            break;

                        case "done":
                            Console.Clear();
                            break;

                    }

                }


            }

            // end of game
           if (daysLeft == 0)
            {
                float finalScore = totalMoney + (totalBitcoin * btcPrice);

                Console.Clear();
                Console.WriteLine("-------------------------------------------------------------- ");
                Console.WriteLine("Congratulations, " + name + ". Your Final Score is: $" + finalScore, Color.Orange);
            }

        }

        
    }
}
