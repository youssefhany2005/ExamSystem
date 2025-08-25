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
        #region Properties
        public string ExamName { get; set; }

        public int ExamTime { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }
        #endregion

        #region Constructor
        public Exam(string name, int time, int numberOfQuestions, Question[] questions)
        {
            ExamName = name;
            ExamTime = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = questions;
        }
        #endregion

        #region Methods
        public abstract void ShowExam();
    }
       
        #endregion    

    }
