using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public class Answer : ICloneable
    {
        #region Properties
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }
        #endregion

        #region Constructor

        public Answer(int _anwseriId, string _answerText)
        {
            AnswerId = _anwseriId;
            AnswerText = _answerText;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{AnswerId}. {AnswerText}";
        }

        public object Clone()
        {
            return new Answer(AnswerId, AnswerText);
        } 
        #endregion  
    }
}
