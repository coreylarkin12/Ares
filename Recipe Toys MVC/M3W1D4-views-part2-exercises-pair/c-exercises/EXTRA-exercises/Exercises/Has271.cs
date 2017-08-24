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
        * Given an array of ints, return true if it contains a 2, 7, 1 pattern -- a value, followed by 
        * the value plus 5, followed by the value minus 1. 
        * Additionally the 271 counts even if the "1" differs by 2 or less from the correct value.
        * 
        * has271([1, 2, 7, 1]) → true
        * has271([1, 2, 8, 1]) → false
        * has271([2, 7, 1]) → true     
        */
        public bool Has271(int[] nums)
        {
            // Iterate < length-2, so can use i+1 and i+2 in the loop.
            // Return true immediately when seeing 271.
            for (int i = 0; i < (nums.Length - 2); i++)
            {
                int val = nums[i];
                if (nums[i + 1] == (val + 5) &&              // the "7" check
                  Math.Abs(nums[i + 2] - (val - 1)) <= 2)
                {  // the "1" check
                    return true;
                }
            }

            // If we get here ... none found.
            return false;
        }
       
        
    }
}
