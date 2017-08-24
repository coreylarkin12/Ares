using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class _2ndClass : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {

            bool ounces = true;
            bool pounds = true;
            double rate = 0;
            if (weight > 0 && weight <= 2 && ounces == true)
            {
                rate = 0.0035 * distance;
                return rate;
            }
            else if (weight >= 3 && weight <= 8 && ounces == true)
            {
                rate = 0.0040 * distance;
                return rate;
            }
            else if (weight >= 9 && weight <= 15 && ounces == true)
            {
                rate = 0.0047 * distance;
                return rate;
            }
            else if (weight > 0 && weight <= 3 && pounds == true)
            {
                rate = 0.0195 * distance;
                return rate;
            }
            else if (weight >= 4 && weight <= 8 && pounds == true)
            {
                rate = 0.0450 * distance;
                return rate;
            }
            else
            {
                rate = 0.0500 * distance;
                return rate;
            }
        }
    }
}

//|--------|-----------|-----------|-----------|
//|        | 1st Class | 2nd Class | 3rd Class |
//| Ounces | Per Mile  | Per Mile  | Per Mile  |
//|--------|-----------|-----------|-----------|
//| 0 - 2  |   0.035   |   0.0035  |   0.0020  |
//| 3 - 8  |   0.040   |   0.0040  |   0.0022  |
//| 9 - 15 |   0.047   |   0.0047  |   0.0024  |
//| Pounds |           |           |           |
//| 1 - 3  |   0.195   |   0.0195  |   0.0150  |
//| 4 - 8  |   0.450   |   0.0450  |   0.0160  |
//| 9+     |   0.500   |   0.0500  |   0.0170  |
//|--------|-----------|-----------|-----------|
