using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Tank : IVehicle
    {
        private string tank;


        public Tank(string tank)
        {
            tank = Tanks;  
        }

        public string Tanks
        {
            get;
        }

        public double CalculateToll(int distance)
        {
            double toll = 0;                            //military vehicles pay no toll

            return toll;


        }
    }
}
