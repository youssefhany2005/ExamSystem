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
        public PracticalExam(int time, int numberOfQuestions, Question[] questions)
       : base(time, numberOfQuestions, questions) { }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");
            foreach (var q in Questions)
            {
                q.ShowQuestion();
                Console.WriteLine($"Correct Answer: {q.RightAnswer}\n");
                Console.WriteLine("Good Luck <3");
            }
        }
    }
}
