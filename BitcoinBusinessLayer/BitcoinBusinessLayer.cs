using System;

namespace BitcoinBusinessLayer
{
    public class ServiceCalculationBusinessLayer
    {
        // this service should calculate the service tax
        // need to write a method that takes # of bitcoin parameter, then calculate total service fee
        // return

        public double CalculateBitcoinServiceFee(int total)
        {
            if (total > 1)
            {
                return total * 0.5;
            }
            return total * 0.1;
        }
    }
}
