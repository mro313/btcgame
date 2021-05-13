using System;

namespace ConsoleApp1
{
    class Program
    {

        // to do: complete "end of game"
        // to do: fix math, decimals, float


        static void Main(string[] args)
        {
            int totalBitcoin = 1;
            int totalMoney = 0;
            int totalDays = 5;

            // create Random class (system class)
            Random generateRandom = new Random();


            Console.WriteLine("this is for test class, what is your name?");
            mathExampleObject.Name = Console.ReadLine();
            mathExampleObject.greeting();
            mathExampleObject.calculateBitcoins(totalBitcoin);

            // get player nanme
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.Clear();

            // player instructions
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine(name + ", you have " + totalDays + " days to make the most money possible via trading bitcoins.");
            Console.WriteLine("");
            Console.WriteLine("When there are no more days left, your final score will equal the following: [total money + bitcoin assets]");
            Console.WriteLine("");

            Console.WriteLine("You will start out with " + totalBitcoin + " bitcoins.");
            Console.WriteLine("");


            for (int currentDay = 1; currentDay <= totalDays; currentDay++)
            {
                // local variables
                int daysLeft = totalDays - currentDay;
                int btcPrice = generateRandom.Next(0, 70000); // daily bitcoin price
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
                    Console.WriteLine("   // user actions are Case Sensitive");
                    Console.WriteLine("-------------------------------------------------------------- ");
                    
                    // prompt - input
                    input = Console.ReadLine();

                    // sell logic
                    if (input == "sell")
                    {
                        Console.Clear();
                        Console.WriteLine("You are about to sell " + totalBitcoin + " bitcoins for the following price: $" + btcPrice);
                        Console.WriteLine("");
                        Console.WriteLine("Do you want to proceed? Type Y or N");
                        Console.WriteLine("");
                        string sellBitcoin = Console.ReadLine();

                        if (sellBitcoin == "Y")
                        {
                            Console.Clear();
                            totalMoney = totalBitcoin * btcPrice;
                            totalBitcoin = 0;
                            Console.WriteLine("You sold your bitcoins. You now have $" + totalMoney);
                        }

                        // FIXME
                        // need to add logic for if you sell with 0 bitcoins. that would wipe out your total money

                        else
                        {
                            Console.WriteLine("Sending you back");
                        }

                    }

                    // buy logic
                    if (input == "buy")
                    {
                        var buyBitcoinObject = new BuyClass();
                        // in order to call a method on the instance...need to:
                        // ** you don't need to refer to the class... only the instance!"
                        buyBitcoinObject.BuyBitcoin(totalBitcoin, totalMoney, btcPrice);

                    }

                    if (input == "done")
                    {
                        // exit while loop
                        Console.Clear();
                        break;
                    }

                    else
                    {
                        // 'don't understand, please try again'
                        Console.WriteLine("");
                    }

                }


            }
        }

        
    }
}
