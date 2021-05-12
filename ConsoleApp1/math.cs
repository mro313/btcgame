using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class mathClass
    {
        // data
        public string Name;

        // methods
        public void greeting()
        {
            Console.WriteLine("Hello, " + Name);
        }

        public int calculateBitcoins(int totalBitcoin)
        {
            int newTotalBitcoin = 99 + totalBitcoin;
            Console.WriteLine(newTotalBitcoin);

            return newTotalBitcoin;
        }


    }
}
