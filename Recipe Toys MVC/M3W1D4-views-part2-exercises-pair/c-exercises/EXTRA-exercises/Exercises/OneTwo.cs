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
        * Given a string, compute a new string by moving the first char to come after the next two chars, so "abc" yields "bca". 
        * Repeat this process for each subsequent group of 3 chars, so "abcdef" yields "bcaefd". 
        * Ignore any group of fewer than 3 chars at the end.
        *
        * oneTwo("abc") → "bca"
        * oneTwo("tca") → "cat"
        * oneTwo("tcagdo") → "catdog"
        */
        public string OneTwo(string str)
        {
            string st = str;
            string s = str;
            int lengthOfMovingPart = 2;
            if (str.Length <= 3)
            {
                s = string.Format("{0}{1}", s.Substring(s.Length - lengthOfMovingPart),
               s.Substring(0, s.Length - lengthOfMovingPart));

                return s;
            }
            else if (str.Length > 3 && str.Length < 7)
            {
                s = string.Format("{0}{1}", s.Substring(1, s.Length -4),
              s.Substring(0, 1));
                st = string.Format("{0}{1}", st.Substring(4, st.Length - 4),
                    st.Substring(3, 1));
                return s + st;
            }
            else if(str.Length >8)
            {
                s = string.Format("{0}{1}", s.Substring(2, s.Length - lengthOfMovingPart),
             s.Substring(0, s.Length - lengthOfMovingPart));
                st = string.Format("{0}{1}", st.Substring(0, st.Length - 4),
                    st.Substring(5, 2));
                return s;
               
            }
            return str;


        }
    }
}
