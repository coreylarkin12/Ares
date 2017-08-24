using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class FexEd : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            
            double rate = 20.00;

            if (distance > 500 )
            {
                rate = rate + 5.00;
                return rate;
            }
            if (weight > 48)
            {
                rate = rate + 3.00;
                return rate;
            }
            else
            {
                return rate;
            }
        }
    }
}
