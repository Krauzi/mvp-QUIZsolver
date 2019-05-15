using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZsolver
{
    interface IView
    {
        string QuestionText { get; set; }
        int QuestionNumber { get; set; }
        uint Points { get; set; }
        uint Time { get; set; }
        List<Tuple<string, bool>> Answers { get;  set; }
        List<Tuple<string, uint, List<Tuple<string, bool>>>> Questions { set; }


        void ShowMessage(string MessageText);

        event Action<string> LoadQuiz;
        event Action<int> GiveAnswer;
        event Action<int> GetQuestion;
        event Action TimerTick;
        event Action TimeOver;
    }
}
