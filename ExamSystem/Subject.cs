using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject(int id, string name, Exam exam)
        {
            SubjectId = id;
            SubjectName = name;
            SubjectExam = exam;
        }

        public void CreateExam()
        {
            SubjectExam.ShowExam();
        }

        public void ShowSubjectData()
        {
            Console.WriteLine($"Subject: {SubjectName} (ID: {SubjectId})");
            Console.WriteLine($"Exam: {SubjectExam.ExamName}");
            Console.WriteLine($"Duration: {SubjectExam.ExamTime} minutes");
            Console.WriteLine($"Number of Questions: {SubjectExam.NumberOfQuestions}");
            Console.WriteLine("-------------------------");
        }

        public override string ToString()
        {
            return $"Subject: {SubjectName} (ID: {SubjectId})";
        }
    }
}
