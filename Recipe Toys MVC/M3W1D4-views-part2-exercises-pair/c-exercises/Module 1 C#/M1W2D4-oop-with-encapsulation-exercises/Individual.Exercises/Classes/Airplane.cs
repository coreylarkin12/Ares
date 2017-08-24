using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        private string planeNumber;
        private int bookedFirstClassSeats;
        private int availableFirstClassSeats;
        private int totalFirstClassSeats;
        private int bookedCoachSeats;
        private int availableCoachSeats;
        private int totalCoachSeats;
        private int totalNumberOfSeats;

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.planeNumber = planeNumber;
            this.totalCoachSeats = totalCoachSeats;
            this.totalFirstClassSeats = totalFirstClassSeats;
            bookedCoachSeats = BookedCoachSeats;
            bookedFirstClassSeats = BookedFirstClassSeats;
            availableCoachSeats = TotalCoachSeats - BookedCoachSeats;
            availableFirstClassSeats = TotalFirstClassSeats - BookedFirstClassSeats;
            totalNumberOfSeats = TotalNumberOfSeats;

        }
        public string PlaneNumber
        {
            get
            {
                return planeNumber;
            }

        }
        public int BookedFirstClassSeats
        {
            get
            {
                return bookedFirstClassSeats;
            }
        }
        public int AvailableFirstClassSeats
        {
            get
            {
                return availableFirstClassSeats;
            }
        }
        public int TotalFirstClassSeats
        {
            get
            {
                return totalFirstClassSeats;
            }
        }
        public int BookedCoachSeats
        {
            get
            {
                return bookedCoachSeats;
            }
        }
        public int AvailableCoachSeats
        {
            get
            {
                return availableCoachSeats;
            }
        }
        public int TotalCoachSeats
        {
            get
            {
                return totalCoachSeats;
            }
        }
        public int TotalNumberOfSeats
        {
            get
            {
                return totalNumberOfSeats;
            }
            set
            {
                totalNumberOfSeats = value;
            }
        }
        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if (availableFirstClassSeats - totalNumberOfSeats > 0 && forFirstClass == false)
            {
                return true;
            }
            else if (availableFirstClassSeats - totalNumberOfSeats == 0 || forFirstClass == false)
            {
                return true;
            }
            else
            {
                return true;
            }
            
        
        }
        
    }


}

