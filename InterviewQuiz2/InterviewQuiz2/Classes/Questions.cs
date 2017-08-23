using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace InterviewQuiz2.Classes
{
    public class Questions
    {
        List<string> resultsCorrect = new List<string>();
        List<string> resultsIncorrect = new List<string>();
        private string input;
        private string answerA = "A";
        private string answerB = "B";
        private string answerC = "C";
        private string answerD = "D";

        public void AskQuestions()
        {

            Console.WriteLine("Question 1");
            Console.WriteLine("What is Inheritance? ");
            Console.WriteLine();
            Console.WriteLine("A) Allows Developers to create new classes that reuse, extend, and modify behavior defined in other classes.");
            Console.WriteLine("B) Encloses Objects in a logical package by limiting access to implementation details.");
            Console.WriteLine("C) Allows developers to create new classes that extend the behavior defined in other classes.");
            Console.WriteLine("D) All of the above.");
            Console.WriteLine();
            input = Console.ReadLine();
            Console.WriteLine();

            try
            {
                if (input == answerA.ToLower())
                {
                    Console.WriteLine("Correct");
                    Thread.Sleep(1000);

                    Questions nextQuestion = new Questions();
                    resultsCorrect.Add("Correct");
                    nextQuestion.QuestionTwo();
                    Console.WriteLine(nextQuestion.ToString());
                }
                else if (input == answerB.ToLower() || input == answerC.ToLower() || input == answerD.ToLower())
                {
                    Console.WriteLine("Incorrect");
                    Thread.Sleep(1000);

                    Questions nextQuestion = new Questions();
                    resultsIncorrect.Add("Incorrect");
                    nextQuestion.QuestionTwo();
                    Console.WriteLine(nextQuestion.ToString());
                }
                else
                {
                    Console.WriteLine("Please enter a correct Value");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter A B C or D only with no numbers or other letters.");
            }

        }

        public void QuestionTwo()
        {
            Console.Clear();

            Console.WriteLine("Question 2");
            Console.WriteLine("What is the difference between a class and an object? ");
            Console.WriteLine();
            Console.WriteLine("A) A class is an instance of an object, An object is the definition of a class.");
            Console.WriteLine("B) An object is an instance of a class, A class is the definition of an object.");
            Console.WriteLine("C) Class contain objects and methods, Objects contain gets and sets.");
            Console.WriteLine("D) All of the above.");
            Console.WriteLine();
            input = Console.ReadLine();
            Console.WriteLine();

            try
            {
                if (input == answerB.ToLower())
                {
                    Console.WriteLine("Correct");
                    Thread.Sleep(1000);

                    Questions finalResults = new Questions();
                    resultsCorrect.Add("Correct");
                    finalResults.QuestionThree();
                    Console.WriteLine(finalResults.ToString());
                }
                else if (input == answerA.ToLower() || input == answerC.ToLower() || input == answerD.ToLower())
                {
                    Console.WriteLine("Incorrect");
                    Thread.Sleep(1000);

                    Questions finalResults = new Questions();
                    resultsIncorrect.Add("Incorrect");
                    finalResults.QuestionThree();
                    Console.WriteLine(finalResults.ToString());
                }
                else
                {
                    Console.WriteLine("Please enter a correct Value");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter A B C or D only with no numbers or other letters.");
            }
        }
        public void QuestionThree()
        {
            Console.Clear();

            Console.WriteLine("Question 3");
            Console.WriteLine("What is the difference between a FOR and WHILE loop? ");
            Console.WriteLine();
            Console.WriteLine("A) A FOR loop is used when you know how many time you need to iterate through the code.");
            Console.WriteLine("B) A While loop is used when you need to repeat something until a given statement is true.");
            Console.WriteLine("C) You can use a do while loop instead of just while as well.");
            Console.WriteLine("D) All of the above.");
            Console.WriteLine();
            input = Console.ReadLine();
            Console.WriteLine();

            try
            {
                if (input == answerD.ToLower())
                {
                    Console.WriteLine("Correct");
                    Thread.Sleep(1000);

                    Questions finalResults = new Questions();
                    resultsCorrect.Add("Correct");
                    finalResults.Result();
                    Console.WriteLine(finalResults.ToString());
                }
                else if (input == answerA.ToLower() || input == answerC.ToLower() || input == answerB.ToLower())
                {
                    Console.WriteLine("Incorrect");
                    Thread.Sleep(1000);

                    Questions finalResults = new Questions();
                    resultsIncorrect.Add("Incorrect");
                    finalResults.Result();
                    Console.WriteLine(finalResults.ToString());
                }
                else
                {
                    Console.WriteLine("Please enter a correct Value");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter A B C or D only with no numbers or other letters.");
            }
        }
        public void Result()
        {

            Console.Clear();

            Console.WriteLine("You have completed the Quiz, here are your results");
            Console.WriteLine();
            if (resultsCorrect.Contains("Correct") || resultsIncorrect.Contains("Incorrect"))
            {
                Console.WriteLine("You got " + resultsCorrect.Count + " " + "questions correct and " + resultsIncorrect.Count.ToString() + " " + "questions incorrect.");
            }
            else
            {
                Console.WriteLine("You Suck");
            }


        }
    }
}
