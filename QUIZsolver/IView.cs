using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZsolver
{
    interface IView
    {
        List<Tuple<string, bool>> Answers { set; }
        List<Tuple<string, uint, List<Tuple<string, bool>>>> Questions { set; }

        void ShowMessage(string MessageText);

        event Action<string> LoadQuiz;

    }
}
