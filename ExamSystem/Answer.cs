using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class Answer : ICloneable
    {
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }

        public Answer(int _anwseriId, string _answerText)
        {
            AnswerId = _anwseriId;
            AnswerText = _answerText;
        }
        public override string ToString()
        {
            return $"{AnswerId}. {AnswerText}";
        }

        public object Clone()
        {
            return new Answer(AnswerId, AnswerText);
        }
    }
}
