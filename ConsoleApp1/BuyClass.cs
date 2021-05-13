using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BuyClass
    {
        // return type = we use a tuple here
        public (int, int) BuyBitcoin(int totalBitcoin, int totalMoney, int btcPrice)
        {
            int potentialBuyAmount = (totalMoney / btcPrice);

            if (potentialBuyAmount > 0)
            {
                // let them buy
                Console.Clear();
                Console.WriteLine("You are about to buy " + potentialBuyAmount + " bitcoins for the following price: $" + btcPrice);
                Console.WriteLine("");
                Console.WriteLine("Do you want to proceed? Type Y or N");
                Console.WriteLine("");
                string buyBitcoin = Console.ReadLine();

                if (buyBitcoin == "Y")
                {
                    Console.Clear();
                    totalBitcoin = potentialBuyAmount;
                    totalMoney = 0;
                    Console.WriteLine("You bought some bitcoins. You now have " + totalBitcoin + " bitcoins.");
                    return (totalBitcoin, totalMoney);
                    // return type needs to be same way you sent it (input)
                }

                // FIXME
                // need to add when you can't buy

                else
                {
                    Console.WriteLine("Sending you back");
                }
            }

            else
            {
                Console.WriteLine("Sending you back");
            }
        }


    }
}
