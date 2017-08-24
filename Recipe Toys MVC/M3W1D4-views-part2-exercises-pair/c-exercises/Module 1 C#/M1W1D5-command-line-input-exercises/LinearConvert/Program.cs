using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearConvert
{
    class Program
    {
        /*
         The foot to meter conversion formula is:
 	        m = f * 0.3048
 	
         The meter to foot conversion formula is:
 	        f = m * 3.2808399
 	
         Write a command line program which prompts a user to enter a length, and whether the measurement is in (m)eters or (f)eet.
         Convert the length to the opposite measurement, and display the old and new measurements to the console.
  
         C:\Users> LinearConvert
         Please enter the length: 58
         Is the measurement in (m)eter, or (f)eet? f
         58f is 17m.
         */

        static void Main(string[] args)
        {
            string meter = "m";
            string feet = "f";
            
            Console.WriteLine("Please enter the length: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Is the measurement in (m)eter or (f)eet?");
            string userAns = Console.ReadLine();
            int userMF = Convert.ToInt16(userInput);

            if(userAns == meter)
            {
                int fM = Convert.ToInt16(userMF * 3.2808399);
                Console.WriteLine($"{userInput}m is {fM}f");
            }
            else if(userAns == feet)
            {
                int Mf = Convert.ToInt16(userMF * 0.3048);
                Console.WriteLine($"{userInput}f is {Mf}m");
            }
            else
            {
                Console.WriteLine("You entered the wrong information, please try again.");
            }
            Console.Read();

        }
    }
}
