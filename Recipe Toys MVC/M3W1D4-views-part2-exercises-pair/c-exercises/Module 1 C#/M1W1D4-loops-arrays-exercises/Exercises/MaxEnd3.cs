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
         Given an array of ints length 3, figure out which is larger between the first and last elements 
         in the array, and set all the other elements to be that value. Return the changed array.
         maxEnd3([1, 2, 3]) → [3, 3, 3]
         maxEnd3([11, 5, 9]) → [11, 11, 11]
         maxEnd3([2, 11, 3]) → [3, 3, 3]
         */
        public int[] MaxEnd3(int[] nums)
        {
            int[] maxNum = new int[3];
            maxNum[0] = nums[0];

            if (nums[2] >= maxNum[0])
                maxNum[0] = nums[2];
            maxNum[2] = maxNum[0];
            maxNum[1] = maxNum[0];

            return maxNum;
        }

    }
}
