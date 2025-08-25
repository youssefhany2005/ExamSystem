using ExamSystem.ExamSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public abstract class Exam
    {
        public int ExamTime { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        protected Exam(int time, int numberOfQuestions, Question[] questions)
        {
            ExamTime = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
        }


        public abstract void ShowExam();
    }

}
