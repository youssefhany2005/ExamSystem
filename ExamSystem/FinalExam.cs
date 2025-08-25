using ExamSystem.ExamSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class FinalExam : Exam
    {
        #region Constructor
        public FinalExam(string name, int time, int numberOfQuestions, Question[] questions)
      : base(name, time, numberOfQuestions, questions) { }
        #endregion

        #region Methods
        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");
            int totalMark = 0;
            foreach (var q in Questions)
            {
                q.ShowQuestion();
                Console.WriteLine();
                Console.WriteLine("Good Luck <3");
                totalMark += q.Mark;
            }
            Console.WriteLine($"Total Exam Marks = {totalMark}");
        } 
        #endregion  

    }
}
