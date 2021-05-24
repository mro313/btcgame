using System;

namespace ConsoleApp1
{
    class Program
    {

        // to do: fix math, decimals, float
        // to do: add user input for length of game


        static void Main(string[] args)
        {
            int totalBitcoin = 1;
            int totalMoney = 0;
            int totalDays = 5;

            //moved this from loop, to global variable
            int currentDay = 1;

            //move these from local, to global variable to be used later
            int daysLeft = 0;
            int btcPrice = 0;

            // create Random class (system class)
            Random generateRandom = new Random();


            // get player nanme
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.Clear();

            // player instructions
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine(name + ", you have " + totalDays + " days to make the most money possible via trading bitcoins.");
            Console.WriteLine("");
            Console.WriteLine("When there are no more days left, your final score will equal the following: [total money + bitcoin assets]");
            Console.WriteLine("");

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
                    Console.WriteLine("Today is day " + currentDay + ". You have " + daysLeft + " days left.");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Current bitcoin price is: $" + btcPrice);
                    Console.WriteLine("You have " + totalBitcoin + " bitcoins.");
                    Console.WriteLine("You have $" + totalMoney + " dollars.");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("What do you want to do?");
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
                int finalScore = totalMoney + (totalBitcoin * btcPrice);

                Console.Clear();
                Console.WriteLine("-------------------------------------------------------------- ");
                Console.WriteLine("Congratulations, " + name + ". Your Final Score is: $" + finalScore);
            }

        }

        
    }
}
