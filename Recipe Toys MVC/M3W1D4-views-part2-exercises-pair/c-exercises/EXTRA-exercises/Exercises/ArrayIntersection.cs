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
        CHALLENGE: Using array A and array B, return an array that is the intersection of both A and B.
        The intersection includes numbers that appear in both arrays.

            ArrayIntersection([1, 3, 5], [1, 5, 7]) → [1, 5]
            ArrayIntersection([1], [1, 5, 7]) → [1]
            ArrayIntersection([1, 1, 1], [1, 5, 7]) → [1]
            ArrayIntersection([], []) → []
        */
        public int[] ArrayIntersection(int[] a, int[] b)
        {
            List<int> theAnswer = new List<int>();
            foreach(int stuff in a)
            {
                if(b.Contains(stuff))
                {
                    if(theAnswer.Contains(stuff) == false)
                    {
                        theAnswer.Add(stuff);
                    }
                   
                }
                else if(b.Length == 0 && a.Length == 0)
                {
                   int[] c = new int[] { };
                   
                    return c;
                }
            }
            return theAnswer.ToArray();
        }
    }
}
