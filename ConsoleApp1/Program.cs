using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalBitcoin = 1;
            int totalMoney = 0;
            int totalDays = 5;

            // create Random class (system class)
            Random generateRandom = new Random();

            // get player nanme
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.Clear();

            // player instructions
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine(name + ", you have " + totalDays + " days to make the most money possible via buying and selling bitcoins.");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Currently you have " + totalBitcoin + " bitcoins. And you have $" + totalMoney + ".");
            Console.WriteLine("");


            for (int currentDay = 0; currentDay <= totalDays; currentDay++)
            {
                // local variables
                int daysLeft = totalDays - currentDay;
                int btcPrice = generateRandom.Next(0, 70000); // daily bitcoin price

                // print current day, days left
                Console.WriteLine("Today is day " + currentDay + ". You have " + daysLeft + " days left.");
                Console.WriteLine("");
                Console.WriteLine("");
                
                while (input != "done")
                {
                    // prompt - menu
                    Console.WriteLine("-------------------------------------------------------------- ");
                    Console.WriteLine("What do you want to do? Type MENU to see the list of options.");
                    Console.WriteLine("-------------------------------------------------------------- ");
                    
                    // prompt - input
                    string input = Console.ReadLine();

                    // logic, use else if
                    if (input == "menu")
                    {
                        Console.WriteLine();
                        Console.WriteLine("-------------------------------------------------------- ");
                        Console.WriteLine("// type 'price' to see today's btc price");
                        Console.WriteLine("// type 'money' to see how much money you have ");
                        Console.WriteLine("// type 'buy' to buy bitcoins");
                        Console.WriteLine("// type 'sell' to sell your bitcoins");
                        Console.WriteLine("-------------------------------------------------------- ");
                        Console.WriteLine();
                        break;
                    }

                    else if (input == "price")
                    {
                        // print btc price
                        Console.WriteLine("Current bitcoin price is: $" + btcPrice);
                        break;
                    }

                   
                    }

                    else if (input == "done")
                    {
                        // exit while loop
                        break;
                    }

                    else
                    {
                        // 'don't understand, please try again'
                        Console.WriteLine("don't understand, try again");
                    }

                }

              


            }
        }
    }
}
