using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorProgram
{
    /// <summary>
    /// This class does all the calculations for delimeters, positive numbers and negative numbers.
    /// TODO: Detect delimeters longer than one character.
    /// </summary>
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            int sum = 0;

            if (numbers == "")
            {
                return sum;
            }
            else if (numbers[0] == '/')
            {
                char delimeter = numbers[2];
                string delimeterNumbers = numbers.Substring(4, numbers.Length - 4);
                delimeterNumbers = delimeterNumbers.Replace("n", "0");
                string[] input = delimeterNumbers.Split(delimeter);
                int[] inputedInts = Array.ConvertAll(input, int.Parse);

                return CalculateSum(ref sum, inputedInts);

            }
            else
            {
                string[] input = numbers.Split(new char[] { ',', '\n' });
                int[] inputedInts = Array.ConvertAll(input, int.Parse);

                return CalculateSum(ref sum, inputedInts);
            }
        }

        private static int CalculateSum(ref int sum, int[] inputedInts)
        {
            bool negativeDetected = false;
            String negativesCollected = "";
            foreach (int number in inputedInts)
            {
                if (number < 0)
                {
                    negativeDetected = true;
                    negativesCollected = negativesCollected + number.ToString();
                }
                else
                {
                    sum += number;
                }
            }
            if (negativeDetected)
            {
                throw new NegativeException(string.Format("Negatives are not allowed {0}", negativesCollected));
            }
            else
            {
                return sum;
            }
        }
    }

    public class NegativeException : Exception
    {
        public NegativeException(string message)
           : base(message)
        {
        }
    }
}
