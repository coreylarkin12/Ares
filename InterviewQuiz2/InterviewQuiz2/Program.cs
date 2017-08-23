using System;
using InterviewQuiz2.Classes;

namespace InterviewQuiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Questions Ask = new Questions();
            Ask.AskQuestions();

            Console.WriteLine(Ask.ToString());
            Console.Read();
        }
    }
}
