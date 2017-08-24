using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSplitter
{
    public static class SplitThatFile
    {
        public static void SplitMe()
        {
            List<string> quizQuestions = new List<string>();

            string directory = Environment.CurrentDirectory;
            string fileName = "mytest.txt";
            string fullPath = Path.Combine(directory, fileName);

            int FileCount = 1;
            int CurrentCount = 0;
            Console.WriteLine("What is the name of the input file? ");
            string myfileName = Console.ReadLine();
            Console.WriteLine("How many lines of text (max) should be in the split files? ");
            int textMax = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**GENERATING OUTPUT**");
            Console.WriteLine();

            StreamWriter sw = new StreamWriter(myfileName + "-" + FileCount.ToString() + ".txt");

            using (StreamReader sr = new StreamReader(fullPath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (CurrentCount < textMax)
                    {
                        //write to new file
                        sw.WriteLine(line);
                        CurrentCount += 1;
                    }
                    else
                    {
                        //close writer
                        FileCount += 1;
                        CurrentCount = 1;
                        sw = new StreamWriter(myfileName + "-" + FileCount.ToString() + ".txt");
                        sw.WriteLine(line);

                        //Can't figure out why its not writing the lines into the text files it generates them but doesn't write the lines
                    }
                }
            }
        }
    }
}