using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataRomanNumerals
    {
        // I got the dictionary done and half of the bottom code and then got stuck so I did
        // research online for help on how to go about the rest of the program but idk if I 
        // did it correctly or not. All comments are appreciated I go back and update my code with the input given.

        public Dictionary<int, string> romanToNum = new Dictionary<int, string>
        {
            {1000,"M"},
            {900,"CM"},
            {500,"D"},
            {400,"CD"},
            {100,"C"},
            {90,"XC"},
            {50,"L"},
            {40,"XL"},
            {10,"X"},
            {9,"IX"},
            {5,"V"},
            {4,"IV"},
            {1 ,"I"}
        };

        public string ToRoman(int input)
        {
            var romanNumeral = string.Empty;

            foreach (var romanNums in romanToNum.Keys)
            {
                while (input >= romanNums)
                {
                    romanNumeral += romanToNum[romanNums];
                    input -= romanNums;
                }
            }
            return romanNumeral;
        }
    }
}
