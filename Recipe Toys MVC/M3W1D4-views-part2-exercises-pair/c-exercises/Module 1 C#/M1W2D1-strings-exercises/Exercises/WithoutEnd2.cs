using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return a version without both the first and last char of the string. The string 
         may be any length, including 0.
         withouEnd2("Hello") → "ell"
         withouEnd2("abc") → "b"
         withouEnd2("ab") → ""
         */
        public string WithouEnd2(string str)
        {
            int theEnd = str.Count();
            if(theEnd >= 3)
            {
                return str.Substring(1, theEnd - 2);
            }
            else
            {
                return "";
            }
          
        }
    }
}
