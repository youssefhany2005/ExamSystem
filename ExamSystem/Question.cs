using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    using System;

    namespace ExamSystem
    {
        public abstract class Question : ICloneable,IComparable<Question>
        {

            #region Properies
            public string Header { get; set; }
            public string Body { get; set; }
            public int Mark { get; set; }


            public Answer[] QuestionAnswers { get; set; }
            public Answer RightAnswer { get; set; }
            public Answer? ReceivedAnswer { get; set; } // Student's answer 
            #endregion

            #region Constructor

            protected Question(string header, string body, int mark, Answer[] answers, Answer rightAnswer)
            {
                Header = header;
                Body = body;
                Mark = mark;
                QuestionAnswers = answers;
                RightAnswer = rightAnswer;
                ReceivedAnswer = null;
            }
            #endregion

            #region Methods
            public override string ToString()
            {
                return $"{Header}\n{Body} (Mark: {Mark})";
            }

            public bool IsCorrect()
            {
                return ReceivedAnswer != null && ReceivedAnswer.AnswerId == RightAnswer.AnswerId;
            } 

            public int CompareTo(Question? other)
            {
                if (other == null) return 1;
                return this.Mark.CompareTo(other.Mark);
            }

            public object Clone()
            {
                return MemberwiseClone();
            }

            public abstract void ShowQuestion();
            #endregion

        }
    }

}
