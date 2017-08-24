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
        * Given two strings, word and a separator sep, return a big string made of count occurrences 
        * of the word, separated by the separator string.
        *
        *
        * repeatSeparator("Word", "X", 3) → "WordXWordXWord"
        * repeatSeparator("This", "And", 2) → "ThisAndThis"
        * repeatSeparator("This", "And", 1) → "This"
        * 
        */
        public string RepeatSeparator(string word, string sep, int count)
        {
            if (count == 0)
            { return ""; }

            StringBuilder build = new StringBuilder(count * word.Length + sep.Length * (count - 1));

            for(int i = 0; i < count -1; i++)
            {
                build.Append(word);
                build.Append(sep);
            }
            build.Append(word);

            return build.ToString();
        }
    }
}
