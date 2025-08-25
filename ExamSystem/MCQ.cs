using ExamSystem.ExamSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class MCQ : Question
    {
        public MCQ(string body, int mark, Answer[] answers, Answer rightAnswer)
         : base("MCQ", body, mark, answers, rightAnswer)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override void ShowQuestion()
        {
            Console.WriteLine(ToString());

            foreach (var answer in QuestionAnswers)
            {
                Console.WriteLine(answer.ToString());
            }
            while (true)
            {
                Console.Write("Enter the Answer Id: ");
                string? input = Console.ReadLine()?.Trim();
                int RightAnswerId;
                if (int.TryParse(input, out RightAnswerId))
                {
                    bool found = false;
                    foreach (var ans in QuestionAnswers)
                    {
                        if (ans.AnswerId == RightAnswerId)
                        {
                            ReceivedAnswer = ans;
                            found = true;
                            break;
                        }
                    }
                    if (found)
                        break;
                }

                Console.WriteLine("Invalid choice");
            }
        }
    }
}   

