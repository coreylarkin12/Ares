using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Models;

namespace Capstone.Models
{
    public class Site
    {

        public int SiteId { get; set; }
        public int CampgroundID { get; set; }
        public int SiteNumber { get; set; }
        public int MaxOccupancy { get; set; }
        public string Accessible { get; set; }
        public int MaxRvLength { get; set; }
        public string Utility { get; set; }
        public double Cost { get; set; }
        public double totalCost { get; set; }


        public override string ToString()
        {
            return "".PadRight(5) + SiteNumber.ToString().PadRight(15) + MaxOccupancy.ToString().PadRight(14) + Accessible.ToString().PadRight(16) +
                MaxRvLength.ToString().PadRight(14) + Utility.ToString().PadRight(13) + "$"+totalCost.ToString().PadRight(10);
        }
    }
}
