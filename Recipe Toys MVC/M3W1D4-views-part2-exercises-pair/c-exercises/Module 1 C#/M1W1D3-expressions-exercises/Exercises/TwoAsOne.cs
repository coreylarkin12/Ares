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
         Given three ints, a b c, return true if it is possible to add two of the ints to get the third.
         twoAsOne(1, 2, 3) → true
         twoAsOne(3, 1, 2) → true
         twoAsOne(3, 2, 2) → false
         */
        public bool TwoAsOne(int a, int b, int c)
        {
            int sumC = a + b;
            int sumB = a + c;
            int sumA = b + c;

            if(sumC == c)
            {
                return true;
            }
            else if(sumA == a)
            {
                return true;
            }
            else if(sumB == b)
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }

    }
}
