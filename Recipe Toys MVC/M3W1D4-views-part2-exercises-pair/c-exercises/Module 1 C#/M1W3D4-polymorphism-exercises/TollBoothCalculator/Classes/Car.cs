using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Car : IVehicle
    {
        private bool hasTrailer;
        private string car;


        public Car(string car)
        {
            this.car = car;
        }

        public Car(bool hasTrailer)
        {
            this.hasTrailer = hasTrailer;
        }
        
               // get properties
        public bool HasTrailer
        {
            get;
        }

        public double CalculateToll(int distance)
        {
            double toll = distance * 0.020;
            double newToll;
            if(hasTrailer == true)                      //Calculation for toll based off distance.
            {
                newToll = toll + 1.00;
                return newToll;
            }
            else
            {
                return toll;
            }
        }
    }
}
