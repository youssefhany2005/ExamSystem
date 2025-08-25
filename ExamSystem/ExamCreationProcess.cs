using ExamSystem.ExamSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public static class ExamCreationProcess
    {
        public static Exam CreateExam()
        {
            
            string? examChoice;
            do
            {
                Console.WriteLine("Choose Exam Stage Final(1) Or Practical(2)");
                examChoice = Console.ReadLine()?.Trim();
                if (examChoice != "1" && examChoice != "2")
                    Console.WriteLine("Invalid Exam Stage You Must Enter Either 1 or 2");
            } while (examChoice != "1" && examChoice != "2");

            
            Console.Write("Enter Exam Name: ");
            string examName = Console.ReadLine()!;

            
            Console.Write("Enter Exam Duration in Hours: ");
            int examTime = int.Parse(Console.ReadLine()!);

            
            Console.Write("Enter number of questions: ");
            int QuestionsCount = int.Parse(Console.ReadLine()!);
            Console.WriteLine("\n");
            
            Question[] questions = new Question[QuestionsCount];

            
            for (int i = 0; i < QuestionsCount; i++)
            {
                Question Q;

                if (examChoice == "1") // Final
                {
                    string? QuestionCategory;
                    do
                    {
                        Console.WriteLine($"Choose Question Category for Q{i + 1}: MCQ(1)  True Or False(2)");
                        QuestionCategory = Console.ReadLine()?.Trim();
                        if (QuestionCategory != "1" && QuestionCategory != "2")
                            Console.WriteLine("Invalid choice");
                    } while (QuestionCategory != "1" && QuestionCategory != "2");

                    Q = QuestionCategory == "1" ? new MCQ() : new TrueOrFalseQuestion();
                }
                else // Practical
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"Creating MCQ Question {i + 1}:");
                    Q = new MCQ();
                }

                if (Q.GetType() == typeof (MCQ)) 
                {
                    MCQ MultipleChoiceQuestion = (MCQ)Q;
                    MultipleChoiceQuestion.SetBody();
                    MultipleChoiceQuestion.SetMark();
                    MultipleChoiceQuestion.SetAnswers();
                    MultipleChoiceQuestion.SetRightAnswer();
                }
                else if (Q.GetType() == typeof (TrueOrFalseQuestion))
                {
                    TrueOrFalseQuestion TrueFalse = (TrueOrFalseQuestion)Q;
                    TrueFalse.SetQuestionBody();
                    TrueFalse.SetMark();
                    TrueFalse.SetRightAnswer();
                }

                questions[i] = Q;
            }


            Exam examObj;

            if (examChoice == "1")
            {
                examObj = new FinalExam(examName, examTime, QuestionsCount, questions);
            }
            else
            {
                examObj = new PracticalExam(examName, examTime, QuestionsCount, questions);
            }


            return examObj;
        }
    }
    
}
