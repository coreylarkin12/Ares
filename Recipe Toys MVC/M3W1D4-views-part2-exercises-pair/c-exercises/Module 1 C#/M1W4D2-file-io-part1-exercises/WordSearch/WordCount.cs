using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WordSearch
{
    public static class WordCount
    {
        public static void ReadFile()
        {
            string folder = Environment.CurrentDirectory;
            string filename = "alices_adventures_in_wonderland.txt";
            string fullpath = Path.Combine(folder, filename);

            Console.WriteLine("Please enter the text you would like to search for: ");
            string keyword = Console.ReadLine();
            Console.WriteLine("Please enter the file path: ");
            Console.ReadLine();
            Console.WriteLine();

            int counter = 1;

            using (StreamReader sr = new StreamReader(fullpath))
            {
                while (!sr.EndOfStream)
                {

                    string line = sr.ReadLine();
                    string lowerCase = keyword.ToLower();
                    string upperCase = keyword.ToUpper();

                    //string.Equals(keyword, keyword, StringComparison.CurrentCultureIgnoreCase);

                    if (line.Contains(keyword) || line.Contains(upperCase) || line.Contains(lowerCase))
                    {
                       
                        Console.WriteLine(counter.ToString() + ") " + line);
                    }
                    counter++;
                    
                }
                Console.Read();
                
            }
           
        }
    }
}
    
    

