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
        public TrueOrFalseQuestion(string body , int mark ,Answer rightAnswer) 
       :base("True Or False", body, mark,new Answer[] {
                      new Answer(1, "True"),
                      new Answer(2, "False")
                      }, rightAnswer)
        {
            
        }
        public override void ShowQuestion()
        {
            while (true)
            {
                Console.WriteLine(ToString());
                foreach (var answer in QuestionAnswers)
                {
                    Console.WriteLine(answer.ToString());
                }
                Console.Write("Your answer 1 = True / 2 = False): ");
                string? Answer = Console.ReadLine()?.Trim();
                int RightAnswerId;
                if (int.TryParse(Answer, out RightAnswerId))
                {
                    foreach (var ans in QuestionAnswers)
                    {
                        if (ans.AnswerId == RightAnswerId)
                        {
                            ReceivedAnswer = ans;
                            break;
                        }
                    }
                }
                else
                    Console.WriteLine("Invalid Answer");
            }
        }
    }
}
