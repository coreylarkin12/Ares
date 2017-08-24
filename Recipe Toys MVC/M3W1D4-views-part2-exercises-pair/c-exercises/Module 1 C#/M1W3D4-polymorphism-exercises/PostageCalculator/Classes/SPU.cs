using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class SPU : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            //bool fourDayGround = true;
            bool ounces = true;
            bool pounds = true;
            double rate = 0;
            //if (fourDayGround == true)
            //{
            //    rate = (weight * 0.0050) * distance;
            //    return rate;
            //}
           
            if (weight > 0 && weight <= 15 && ounces == true)
            {
                rate = 1.75;
                return rate;
            }
            else if (weight > 0 && weight <= 3 && pounds == true)
            {
                rate = (weight * 0.0050) * distance;
                return rate;
            }
            else if (weight >= 4 && weight <= 8 && pounds == true)
            {
                rate = (weight * 0.0050) * distance;
                return rate;
            }
            else
            {
                rate = (weight * 0.0050) * distance;
                return rate;
            }
        }
    }
}
