using QUIZsolver.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZsolver
{
    public partial class Form1 : Form, IView
    {
        private void onLoad(object sender, EventArgs e)
        {
            //Form2 frm = new Form2();
            //frm.FilePath = "";
            //frm.Time = 0;
            //frm.ShowDialog();

            //if (frm.FilePath == "" || frm.Time == 0)
            //{
            //    MessageBox.Show("No quiz time or file specified");
            //    this.Close();
            //    Application.Exit();
            //    return;
            //} else
            //{ 

            //    if (LoadQuiz != null)
            //        LoadQuiz(FilePath);
            //}
            FilePath = @"H:\C#\QUIZsolver\Quizes\ExampleQuiz.json";
            Time = 2;
            if (LoadQuiz != null)
                LoadQuiz(FilePath);
        }

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }
        public List<Tuple<string, bool>> Answers
        {
            set
            {
                flowLayoutPanelAnswers.Controls.Clear();
                for (int i = 0; i < value.Count; i++)
                {
                    AnswerObject answer = new AnswerObject();
                    answer.AnswerText = value[i].Item1;
                    flowLayoutPanelAnswers.Controls.Add(answer);
                }
            }
        }

        public List<Tuple<string, uint, List<Tuple<string, bool>>>> Questions
        {
            set
            {
                flowLayoutPanelQuestions.Controls.Clear();
                for (int i = 0; i < value.Count; i++)
                {
                    Button question = new Button();
                    question.Text = i.ToString();
                    flowLayoutPanelQuestions.Controls.Add(question);
                }
            }
        }

        public uint Points
        {
            get
            {
                return uint.Parse(labelPoints.Text);
            }
            set
            {
                labelPoints.Text = value.ToString();
            }
        }

        public static string FilePath { get; set; }
        public static uint Time { get; set; }
        public static bool NegativePoints { get; set; }

        public void ShowMessage(string MessageText)
        {
            MessageBox.Show(MessageText);
        }

        #region EventHandlers
        public event Action<string> LoadQuiz;
        public event Action<int> GetQuestion;
        #endregion

        #region Events
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(FilePath + Time + NegativePoints);
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
