using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class VendingMachineItem
    {
        private string name;
        private int quantity;
        private double price;

        public VendingMachineItem(string name, double price)
        {
            this.name = name;
            this.price = price;
            quantity = 5;
        }


        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
        } 
    }
}
