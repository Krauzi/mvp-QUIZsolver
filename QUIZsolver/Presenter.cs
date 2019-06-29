using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.view.GetQuestion += View_GetQuestion;
            this.view.GiveAnswer += View_GiveAnswer;
            this.view.TimerTick += View_TimerTick;
            this.view.TimeOver += View_TimeOver;
        }

        private void View_TimeOver()
        {
            this.view.testLasts = false;
            View_GiveAnswer(this.view.lastQuestionIndex);
            MessageBox.Show("Koniec testu! Czas upłynął lub ręcznie zakończyłeś test");
            model.DisplayScore();
        }

        private void View_TimerTick()
        {
                view.Time -= 1;
        }

        private void View_LoadQuiz(string fileName)
        {
            try
            {
                model.LoadQuiz(fileName);
                this.view.Questions = model.GetQuestions;
            }
            catch (Exception)
            {
                view.ShowMessage("Problem with opening file");
            }
        }

        private void View_GetQuestion(int givenQuestionIndex)
        {
            this.view.QuestionNumber = givenQuestionIndex + 1;
            this.view.QuestionText = model.GetQuestionData(givenQuestionIndex).Item1;
            this.view.Points = model.GetQuestionData(givenQuestionIndex).Item2;
            this.view.Answers = model.GetAnswers(givenQuestionIndex);
        }

        private void View_GiveAnswer(int givenQuestionIndex)
        {
            model.GiveAnswer(givenQuestionIndex, this.view.Answers);

            //for (int i = 0; i < this.view.Answers.Count; i++)
            //{
            //    Console.WriteLine(this.view.Answers[i].Item2);
            //}
            this.view.Questions = model.GetQuestions;
        }
    }
}