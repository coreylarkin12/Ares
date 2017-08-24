using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        private double totalMarks;
        private int possibleMarks;
        private string submitterName;
        private string letterGrade;
        private double finalGrade;

        public HomeworkAssignment(int possibleMarks)
        {
            submitterName = SubmitterName;
            totalMarks = TotalMarks;
            finalGrade = (totalMarks / possibleMarks);
            letterGrade = YourGrade(finalGrade);
            this.possibleMarks = possibleMarks;
            

           
            
        }
        public string YourGrade(double finalGrade)
        {

            
            if (finalGrade >= 90)
                return "A";
            if (finalGrade >= 80 && finalGrade <= 89)
                return "B";
            if (finalGrade >= 70 && finalGrade <= 79)
                return "C";
            if (finalGrade >= 60 && finalGrade <= 69)
                return "D";
            else
                return "F";


        }
        public double TotalMarks
        {
            get
            {
                return totalMarks;
            }
            set
            {
                totalMarks = value;
            }
        }
        public int PossibleMarks
        {
            get
            {
                return possibleMarks;
            }
           
            
        }
        public string LetterGrade
        {
            get
            {
                return letterGrade;
            }
           
        }
        public string SubmitterName
        {
            get
            {
                return submitterName;
            }
            set
            {
                submitterName = value;
            }

        }


    }
}
