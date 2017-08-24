using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Campground
    {
        public int CampgroundId { get; set; }
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string OpenMonth { get; set; } //month park opens 
        public string CloseMonth { get; set; } //month parks is open till.
        public double DailyFee { get; set; }

        public override string ToString()
        {
            return CampgroundId.ToString().PadRight(10) + Name.ToString().PadRight(35) + OpenMonth.ToString().PadRight(20) + CloseMonth.ToString().PadRight(20) + "$" + DailyFee.ToString().PadRight(20);
        }
    }
}
