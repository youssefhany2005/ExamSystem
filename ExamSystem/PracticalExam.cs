using ExamSystem.ExamSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class PracticalExam : Exam
    {
        #region Constructor
        public PracticalExam(string name, int time, int numberOfQuestions, Question[] questions)
      : base(name, time, numberOfQuestions, questions) { }
        #endregion

        #region Methods
        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");
            foreach (var question in Questions)
            {
                question.ShowQuestion();
                Console.WriteLine($"Correct Answer: {question.RightAnswer}\n");
                Console.WriteLine("Good Luck <3");
            }
        } 
        #endregion  
    }
}
