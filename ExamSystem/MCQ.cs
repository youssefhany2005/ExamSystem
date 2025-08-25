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
            Console.Write("Enter mark: ");
            Mark = int.Parse(Console.ReadLine()!);
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
            bool valid = false;

            do
            {
                Console.Write("Enter the Right Choice : ");
                string? input = Console.ReadLine()?.Trim();

                if (int.TryParse(input, out RightAnswerId))
                {
                    // Check if the entered id exists in the answers
                    foreach (var ans in QuestionAnswers)
                    {
                        if (ans.AnswerId == RightAnswerId)
                        {
                            RightAnswer = ans;
                            valid = true;
                            break;
                        }
                    }
                }

                if (!valid)
                    Console.WriteLine("Invalid choice");

            } while (!valid);
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
    


