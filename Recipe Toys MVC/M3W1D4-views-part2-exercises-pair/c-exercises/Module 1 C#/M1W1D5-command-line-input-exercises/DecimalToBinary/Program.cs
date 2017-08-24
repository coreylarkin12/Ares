using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        /*
        Write a command line program which prompts the user for a series of decimal integer values  
        and displays each decimal value as itself and its binary equivalent

        C:\Users> DecimalToBinary
        
        Please enter in a series of decimal values (separated by spaces): 460 8218 1 31313 987654321
        
        460 in binary is 111001100
        8218 in binary is 10000000011010
        1 in binary is 1
        31313 in binary is 111101001010001
        987654321 in binary is 111010110111100110100010110001
        */

        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter in a series of decimal values (seperated by spaces): ");
            string[] userInput = Console.ReadLine().Split(' ');
            int[] userBinary = Array.ConvertAll(userInput, int.Parse);

            for(int i = 0; i < userBinary.Count(); i++)
            {
                string ans = Convert.ToString(userBinary[i], 2);
        
                Console.WriteLine($"{userBinary[i]} in binary is {ans}");
               
            }

            Console.Read();

            
        }
    }
}
