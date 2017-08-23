using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FindAndReplace
{
    public static class OpenAndReplace
    {
        public static void OpenFile()
        {
            Console.WriteLine("Please enter the search phrase: ");
            string search = Console.ReadLine();
            Console.WriteLine("Please enter the replace phrase: ");
            string replace = Console.ReadLine();

            try
            {

                bool continueOn = false;
                string sourceFile = "";
                while (!continueOn)
                {
                    Console.WriteLine("Please enter the source file path: ");
                    sourceFile = Console.ReadLine();

                    if (File.Exists(sourceFile))
                    {
                        continueOn = true;

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("That file does not exist.");
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("Please enter the destination file path: ");
                string destinationFile = Console.ReadLine();

                if (File.Exists(destinationFile))
                {
                    Console.WriteLine();
                    Console.WriteLine("File already exists. Press ENTER to exit.");
                    Console.ReadLine();
                    return;
                }

                using (StreamReader sr = new StreamReader(sourceFile))
                {
                    using (StreamWriter sw = new StreamWriter(destinationFile, true))
                    {
                        while (!sr.EndOfStream)
                        {

                            string line = sr.ReadLine();
                            line = line.Replace(search.ToUpper(), replace.ToUpper());
                            line = line.Replace(search.ToLower(), replace.ToLower());
                            //Below line checks Capitalization...it's long
                            line = line.Replace(String.Concat(search.First().ToString().ToUpper(), search.Substring(1, search.Length - 1)), String.Concat(replace.First().ToString().ToUpper(), replace.Substring(1, replace.Length - 1)));
                            sw.WriteLine(line);


                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("There was an error, please try again.");
            }
        }
    }
}

