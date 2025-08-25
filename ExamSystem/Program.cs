using System.Security.Cryptography.X509Certificates;

namespace ExamSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exam exam = ExamCreationProcess.CreateExam();
            Subject subject = new Subject(1, "Programming", exam);

            subject.ShowSubjectData();
            subject.CreateExam();

        }
    }
}
