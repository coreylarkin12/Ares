using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FizzWriter
{
    public static class FizzBuzz
    {
        public static void FizzBuzzOutput()
        {
            string directory = Environment.CurrentDirectory;
            string filename = "FizzBuzz.txt";
            string fullpath = Path.Combine(directory, filename);

            int counter = 1;

            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                for(int i = 1; i < 301; i++)
                {
                    if(i % 3 == 0 && i % 5 == 0)
                    {
                        sw.WriteLine(counter.ToString() + ") " + "FizzBuzz");
                    }
                    else if(i % 3 == 0)
                    {
                        sw.WriteLine(counter.ToString() + ") " + "Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        sw.WriteLine(counter.ToString() + ") " + "Buzz");
                    }
                    else
                    {
                        sw.WriteLine(counter.ToString() + ") " + i);
                    }
                    counter++;
                }
                Console.Read();
            }
        }
    }
}
