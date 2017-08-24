using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// A shopping cart class stores items in it.
    /// </summary>
    public class ShoppingCart
    {
        private int totalNumberOfItems;
        private decimal totalAmountOwed;

        public decimal GetAveragePricePerItem()
        {
            decimal sum = totalAmountOwed / totalNumberOfItems;
            return sum;
        }
        public void AddItems(int numberOfItems, decimal pricePerItem)
        {
            totalNumberOfItems = numberOfItems;
            totalAmountOwed = (pricePerItem * numberOfItems);
        }
        public void Empty()
        {
            totalAmountOwed = 0;
            totalNumberOfItems = 0;
        }
        public int TotalNumberOfItems
        {
            get
            {
                return totalNumberOfItems;
            }
        }
        public decimal TotalAmountOwed
        {
            get
            {
                return totalAmountOwed;
            }
        }
       
    }
}
