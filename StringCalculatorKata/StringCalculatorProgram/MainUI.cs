using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace StringCalculatorProgram
{
    class MainUI
    {
        /// <summary>
        /// This is the user interface that accepts input and returns the string calculator class.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                string userInput = "";
                Console.WriteLine("Please Enter String For Calculation: ");
                userInput = Console.ReadLine();
                StringCalculator CalculateReuslts = new StringCalculator();
                try
                {
                    Console.WriteLine(CalculateReuslts.Add(userInput));
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
