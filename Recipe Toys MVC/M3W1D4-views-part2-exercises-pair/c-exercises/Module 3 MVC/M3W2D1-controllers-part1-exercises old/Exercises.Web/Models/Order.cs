using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercises.Web.Models
{
    public class Order
    {
        public string FirstName { get; set; }
        public string MiddleInt { get; set; }
        public string LastName { get; set; }
        public string OrderList { get; set; }

        public static List<SelectListItem> Ordered { get; } = new List<SelectListItem>()
        {
            new SelectListItem() {Text = "FirstMILast"},
            new SelectListItem() {Text = "First Last"},
            new SelectListItem() {Text = "Last, First MI"},
            new SelectListItem() {Text = "Last, First"},
            
        };

        public string OrderChange()
        {
            if (OrderList == "FirstMILast")
            {
                
                return FirstName +" "+ MiddleInt + " " + LastName;
            }
            else if(OrderList == "First Last")
            {
                return FirstName + " "+ LastName;
            }
            else if(OrderList == "Last, First MI")
            {
                 return LastName + "," + FirstName + "" + MiddleInt;
            }
            else
            {
                return LastName + "," + FirstName;
            }
        }
    }
}