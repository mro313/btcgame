using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SellClass
    {
        public TradeResult SellBitcoin(int totalBitcoin, int totalMoney, int btcPrice)
        {
            var sellTotal = totalBitcoin * btcPrice;

            // if they can sell:
            if ( totalBitcoin > 0)
            {
                Console.Clear();
                Console.WriteLine("You are about to sell " + totalBitcoin + " bitcoins for the following price: $" + btcPrice);
                Console.WriteLine("");
                Console.WriteLine("Do you want to proceed? Type Y or N");
                Console.WriteLine("");
                string sellBitcoin = Console.ReadLine().ToLower();

                if (sellBitcoin == "y")
                {
                    Console.Clear();
                    totalMoney = totalBitcoin * btcPrice;
                    totalBitcoin = 0;
                    Console.WriteLine("You sold your bitcoins. You now have $" + totalMoney);
                    return new TradeResult { TotalBitcoin = totalBitcoin, TotalMoney = totalMoney };
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Sending you back!");
                    return null;
                }
            }

            else
            {
                Console.Clear();
                Console.WriteLine("You have nothing to sell - sending you back!");
                return null;
            }
        }

    }
}
