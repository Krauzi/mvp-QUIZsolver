using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZsolver.Classes
{
    public class Answer
    {
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }

        public Answer() { }

        public Answer(string AnswerText, bool IsCorrect)
        {
            this.AnswerText = AnswerText;
            this.IsCorrect = IsCorrect;
        }

        public Tuple<string, bool> GetAnswer()
        {
            return new Tuple<string, bool>(AnswerText, IsCorrect);
        }

        public override string ToString()
        {
            return $"{AnswerText} : { IsCorrect}";
        }
    }
}
