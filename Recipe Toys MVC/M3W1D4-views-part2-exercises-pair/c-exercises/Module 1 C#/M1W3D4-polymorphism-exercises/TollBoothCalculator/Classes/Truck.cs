using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Truck : IVehicle
    {
        private int numberOfAxles;
        private string truck;



        public Truck(string truck)                  {
            this.truck = truck;
        }

        public Truck(int numberOfAxles)
        {
            this.numberOfAxles = numberOfAxles;
        }

        public int NumberOfAxles
        {
            get;
        }
       
        public double CalculateToll(int distance)           //calculation for toll based off number of axles on truck 4, 6 ,8+
        {
            double ratePerMile = 0.040;
            double ratePerMileSix = 0.045;
            double ratePerMile8 = 0.048;
            double tollFour = ratePerMile * distance;
            double tollSix = ratePerMileSix * distance;
            double tollEight = ratePerMile8 * distance;

            if (numberOfAxles == 4)
            {
                return tollFour;
            }
            else if(numberOfAxles == 6)
            {
                return tollSix;
            }
            else
            {
                return tollEight;
            }
        }
    }
}
