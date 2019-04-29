using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZsolver
{
    class Presenter
    {
        IView view;
        Model model;
        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.LoadQuiz += View_LoadQuiz;
        }

        private void View_LoadQuiz(string fileName)
        {
            try
            {
                model.LoadQuiz(fileName);
            }
            catch (Exception)
            {
                view.ShowMessage("Problem with opening file");
            }
        }
    }
}
