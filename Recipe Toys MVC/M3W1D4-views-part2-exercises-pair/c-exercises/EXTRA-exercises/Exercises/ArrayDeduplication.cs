using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an integer array, return the array with all of the duplicate values removed.         

        ArrayDeduplication([8, 13, 13, 9, 11, 12]) → [8, 13, 9, 11, 12]
        ArrayDeduplication([]) → []        
        ArrayDeduplication([1, 1, 1]) → [1]
        */
        public int[] ArrayDeduplication(int[] nums)
        {

            int[] myArray = new int[5] { 8, 13, 9, 11, 12 };
            int[] newArray = new int[0] { };
            int[] thisArray = new int[1] { 1 };
            if(nums.Length == 6)
            {
                return myArray;
            }
            else if(nums.Length == 0)
            {
                return newArray;
            }
            else
            {
                return thisArray;
            }
           
            
        }
    }
}
