using ExamSystem.ExamSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    #region Constructor
    public class MCQ : Question
    {
        public MCQ()
         : base("MCQ", "", 0, new Answer[4], null)
        {
        }
        #endregion

    #region Methods

        public void SetBody()
        {
            Console.Write("Enter Question: ");
            Body = Console.ReadLine()!;
        }

        public void SetMark()
        {
            int mark;
            bool valid = false;

            do
            {
                Console.Write("Enter mark for this question: ");
                string? input = Console.ReadLine()?.Trim();

                if (int.TryParse(input, out mark) && mark > 0)
                {
                    Mark = mark;
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid mark! Please enter a positive number.");
                }

            } while (!valid);
        }


        public void SetAnswers()
        {
            for (int i = 0; i < QuestionAnswers.Length; i++)
            {
                Console.Write($"Enter Choice {i + 1}: ");
                QuestionAnswers[i] = new Answer(i + 1, Console.ReadLine()!);
            }
        }

        public void SetRightAnswer()
        {
            int RightAnswerId;
            bool IsvalidChoice = false;

            do
            {
                Console.Write("Enter the Right Choice : ");
                string? Choice = Console.ReadLine()?.Trim();

                if (int.TryParse(Choice, out RightAnswerId))
                {
                    foreach (var ans in QuestionAnswers)
                    {
                        if (ans.AnswerId == RightAnswerId)
                        {
                            RightAnswer = ans;
                            IsvalidChoice = true;
                            break;
                        }
                    }
                }

                if (!IsvalidChoice)
                    Console.WriteLine("Invalid choice");

            } while (!IsvalidChoice);
        }

        public override void ShowQuestion()
        {
            Console.WriteLine(Body);
            foreach (var a in QuestionAnswers)
                Console.WriteLine($"{a.AnswerId}) {a.AnswerText}");
        }
    }
        #endregion
    
}
    


