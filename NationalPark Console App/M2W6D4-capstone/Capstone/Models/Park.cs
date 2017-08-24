using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Park
    {

        public int Id { get; set; }
        public string ParkName { get; set; }
        public string Location { get; set; }
        public DateTime EstablishDate { get; set; }
        public int Area { get; set; }
        public int Visitors { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            string visitors = "";
            visitors = String.Format("{0:n0}", Visitors);
            string area = "";
            area = String.Format("{0:n0}", Area);
            
            return ParkName.ToString().PadRight(5) +" National Park" + "\n" +"Location: ".PadRight(20) + Location.ToString().PadRight(30)+ "\n" + "Established: ".PadRight(20) + EstablishDate.ToShortDateString().PadRight(30) + "\n" +
                "Area: ".PadRight(20) + area.ToString() + " Sq Km".PadRight(30) + "\n" +"Annual Visitors: ".PadRight(20) + visitors.ToString().PadRight(30) + "\n\n" +  Description.ToString().PadRight(30);
        }
    }
}
