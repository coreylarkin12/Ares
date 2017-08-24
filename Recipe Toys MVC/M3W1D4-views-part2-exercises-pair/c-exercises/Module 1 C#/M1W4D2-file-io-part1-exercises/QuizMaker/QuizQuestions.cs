using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuizMaker
{
    public static class QuizQuestions
    {
        public static void QuizResults()
        {

            string directory = Environment.CurrentDirectory;
            string fileName = "sample-quiz-file.txt";

            string fullpath = Path.Combine(directory, fileName);

            List<string> results = new List<string>();
            results.Add("Yellow");
            results.Add("Blue");
            results.Add("Green");
            results.Add("Red");
            results.Add("Not Likely");

            if (results.Contains("Yellow") || results.Contains("Not Likely"))
            {
                Console.WriteLine("What color is the sky? ");
                Console.WriteLine("1. Yellow");
                Console.WriteLine("2. Blue");
                Console.WriteLine("3. Green");
                Console.WriteLine("4. Red");
                Console.WriteLine();
                string yourAnswer = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Your answer: " + yourAnswer);
                if (yourAnswer == "blue" || yourAnswer == "2" || yourAnswer == "Blue" || yourAnswer == "BLUE")
                {
                    Console.WriteLine();
                    Console.WriteLine("Your answer is Correct!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry that isn't correct!");
                }

                Console.WriteLine();
                Console.WriteLine("What are Cleveland's odds of winning a championship?");
                Console.WriteLine("1. Not Likely");
                Console.WriteLine("2. Highly Likely");
                Console.WriteLine("3. Fat Chance");
                Console.WriteLine("4. Who Cares??");
                Console.WriteLine();
                string myAnswer = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Your answer: " + myAnswer);

                if (myAnswer == "Not Likely" || myAnswer == "not likely" || myAnswer == "1" || myAnswer == "NOT LIKELY")
                {
                    Console.WriteLine();
                    Console.WriteLine("RIGHT!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("REALLY? Nope your wrong.");
                }
                if (yourAnswer == "Blue" || yourAnswer == "Blue" || yourAnswer == "2" || yourAnswer == "BLUE" && myAnswer == "Not Likely" || myAnswer == "not likely" || myAnswer == "NOT LIKELY")
                {
                    Console.WriteLine();
                    Console.WriteLine("You got 2 answer(s) correct out of the total 2 questions asked");
                }
                else if (yourAnswer == "Blue" || yourAnswer == "Blue" || yourAnswer == "2" || yourAnswer == "BLUE" && myAnswer == "Highly Likely" || myAnswer == "highly likely" || myAnswer == " Fat Chance" || myAnswer == "fat chance" || myAnswer == "Who Cares??" || myAnswer == "who cares" || myAnswer == "who cares??")
                {
                    Console.WriteLine();
                    Console.WriteLine("You got 1 answer(s) correct out of the total 2 questions asked");
                }
                else if (yourAnswer == "Yellow" || yourAnswer == "yellow" || yourAnswer == "1" || yourAnswer == "Green" || yourAnswer == "green" || yourAnswer == "Red" || yourAnswer == "red" && myAnswer == "Not Likely" || myAnswer == "not likely" || myAnswer == "NOT LIKELY")
                {
                    Console.WriteLine();
                    Console.WriteLine("You got 1 answer(s) correct out of the total 2 questions asked");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You got 0 answer(s) correct out of the total 2 questions asked");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press ENTER to exit...");

            Console.Read();

           
        }
    }
        
}
