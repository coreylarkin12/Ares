using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        /*
         The Fibonacci numbers are the integers in the following sequence:  
	        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
         By definition, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.
 
         Write a command line program which prompts the user for an integer value and display the Fibonacci sequence leading up to that number.
  
         C:\Users> Fiboncci
         Please enter the Fibonacci number: 25
         
         0, 1, 1, 2, 3, 5, 8, 13, 21
         */
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the Fibonacci number: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput > 1)
            {
                Console.WriteLine("The Fibonacci numbers less than " + userInput + " are: ");
                Console.WriteLine("0");
                Console.WriteLine("1");

                int fibNum = 1;
                int fibonacci = 1;
                for (int i = 0; i + fibNum < userInput;)
                {

                    fibonacci = i + fibNum;
                    i = fibNum;
                    fibNum = fibonacci;

                    Console.WriteLine(fibonacci + " ");
                }
            }
            else
            {
                Console.WriteLine("There are no numbers less than " + userInput + " in the series");
            }
            Console.Read();
        }
    }
}
