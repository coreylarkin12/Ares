using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    class WordAndSentanceCount
    {
        public void WordAndSentance()
        {
            Console.Write("What is the filesystem path? ");
            string path = Console.ReadLine();
            Console.Write("What is the file name? ");
            string name = Console.ReadLine();
            try
            {
                string fullpath = Path.Combine(path, name);
                StreamReader sr = new StreamReader(fullpath);
                int wordCount = 0;
                int sentanceCount = 0;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] words = line.Split(' ');
                    wordCount += words.Count();
                    foreach (string word in words)
                    {
                        //if (word.EndsWith(".") || word.EndsWith("!") || word.EndsWith("?"))
                        //{
                        //    sentanceCount++;
                        //}
                        if (word.Contains(".") || word.Contains("!") || word.Contains("?"))
                        {
                            sentanceCount++;
                        }
                    }
                }
                Console.WriteLine("Number of words: " + wordCount);
                Console.WriteLine("Number of sentances: " + sentanceCount);
            }
            catch (Exception)
            {
                Console.WriteLine("There was an error");
            }
        }
    }
}