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
        * Look for patterns like "zip" and "zap" in the string -- length-3, starting with 'z' and 
        * ending with 'p'. Return a string where for all such words, the middle letter is gone, 
        * so "zipXzap" yields "zpXzp".
        *
        * zipZap("zipXzap") → "zpXzp"
        * zipZap("zopzop") → "zpzp"
        * zipZap("zzzopzop") → "zzzpzp"        * 
        */
        public string ZipZap(string str)
        {
            int len = str.Length;

              String finalString = "";

              for (int i = 0; i < len; i++)
            {

                finalString += str.Substring(i, 1);

                if (i > 0 && i < len - 1)
                {

                  if (str[i - 1] == 'z' && str[i + 1] == 'p')

                    finalString = finalString.Substring(0, finalString.Length - 1);
                }
              }
              return finalString;

        }
    }
}
