using ExamSystem.ExamSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class TrueOrFalseQuestion : Question
    {
        #region Constructor
        public TrueOrFalseQuestion()
     : base("True Or False", "", 0, new Answer[] {
                      new Answer(1, "True"),
                      new Answer(2, "False")
                    }, null)
        {

        }
        #endregion

        #region Methods
        public void SetQuestionBody()
        {
            Console.Write("Enter Question ");
            Body = Console.ReadLine()!;
        }

        public void SetMark()
        {
            Console.Write("Enter The Number Of Marks For That Question : ");
            Mark = int.Parse(Console.ReadLine()!);
        }

        //Didn't need to set answers as they are always True or False
        public void SetRightAnswer()
        {
            string? answer;
            int RightAnswerId;
            do
            {
                Console.Write("Enter right answer True(1) Or False(2) ");
                answer = Console.ReadLine()?.Trim();
            } while (!int.TryParse(answer, out RightAnswerId) || (RightAnswerId != 1 && RightAnswerId != 2));

            foreach (var ans in QuestionAnswers)
            {
                if (ans.AnswerId == RightAnswerId)
                {
                    RightAnswer = ans;
                    break;
                }
            }
        }

        public override void ShowQuestion()
        {
            Console.WriteLine(Body);
            foreach (var a in QuestionAnswers)
                Console.WriteLine($"{a.AnswerId}) {a.AnswerText}");

            string? Q;
            int Choice;
            do
            {
                Console.Write("Your answer True(1) Or False(2): ");
                Q = Console.ReadLine()?.Trim();
            } while (!int.TryParse(Q, out Choice) || (Choice != 1 && Choice != 2));

            foreach (var ans in QuestionAnswers)
            {
                if (ans.AnswerId == Choice)
                {
                    ReceivedAnswer = ans;
                    break;
                }
            }
        } 
        #endregion  

    }
}
