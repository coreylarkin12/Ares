using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {
        private int result = 0;

        public Calculator(int startingResult)
        {
            result = startingResult;
        }
        public int Result
        {
            get
            {
                return result;
            }
        }

        public int Add(int addend)
        {
            result = result + addend;
            return result;
        }

        public int Subtract(int subtrahend)
        {
            result = result - subtrahend;
            return result;
        }

        public int Multiply(int multiplier)
        {
            result = result * multiplier;
            return result;
        }

        public int Power(int exponent)
        {
            result = result ^ exponent;
            return result;
        }

        public void Reset()
        {
            result = 0;
        }

//        Method Name Return Type Description
//        Add(int addend) int Adds addend to result and returns the current value of result.
//        Subtract(int subtrahend)    int Subtracts subtrahend from the current value of result and returns the current value of result.
//        Multipy(int multiplier) int Multiplies current result by multiplier and returns the current value of result.
//        Power(int exponent) int Raises result to power of exponent.Negative exponents should use the absoluve value.Returns the current value of result
//        Reset() void Resets result to 0.

    }
}
