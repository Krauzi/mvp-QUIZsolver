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
            SelectedQuestionIndex = 0;
            if (LoadQuiz != null)
                LoadQuiz(FilePath);
            if (GetQuestion != null)
                GetQuestion(SelectedQuestionIndex);

        }

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }

        public string QuestionText
        {
            get
            {
                return labelQuestion.Text;
            }
            set
            {
                labelQuestion.Text = value;
            }
        }

        public int QuestionNumber
        {
            get
            {
                return int.Parse(labelQuestionNumber.Text);
            }
            set
            {
                labelQuestionNumber.Text = value.ToString();
            }
        }

        public List<Tuple<string, bool>> Answers
        {
            get
            {
                List<Tuple<string, bool>> answers = new List<Tuple<string, bool>>();
                foreach (AnswerObject obj in flowLayoutPanelAnswers.Controls)
                {
                    if (obj.AnswerText != "")
                    {
                        Answer answer = new Answer(obj.AnswerText, obj.AnswerChecked);
                        answers.Add(answer.GetAnswer());
                    }
                }
                return answers;
            }
            set
            {
                flowLayoutPanelAnswers.Controls.Clear();
                for (int i = 0; i < value.Count; i++)
                {
                    AnswerObject answer = new AnswerObject();
                    answer.AnswerText = value[i].Item1;
                    answer.AnswerChecked = value[i].Item2;
                    flowLayoutPanelAnswers.Controls.Add(answer);
                }
            }
        }

        public List<Tuple<string, uint, List<Tuple<string, bool>>>> Questions
        {
            set
            {
                flowLayoutPanelQuestions.Controls.Clear();
                for (int i = 1; i < value.Count + 1; i++)
                {
                    Button question = new Button();
                    question.Text = i.ToString();
                    question.Width = 28;
                    question.Height = 28;

                    bool hasAnswer = false;
                    for (int j = 0; j < value[i - 1].Item3.Count; j++)
                    {
                        if (value[i - 1].Item3[j].Item2 == true)
                        {
                            hasAnswer = true;
                            break;
                        }
                    }

                    if (hasAnswer) question.BackColor = Color.Green;
                    else question.BackColor = Color.Red;
                    question.Click += new EventHandler(this.Question_Click);
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


        public int SelectedQuestionIndex { get; set; }


        public static string FilePath { get; set; }
        public static uint Time { get; set; }
        public static bool NegativePoints { get; set; }

        public void ShowMessage(string MessageText)
        {
            MessageBox.Show(MessageText);
        }

        #region EventHandlers
        public event Action<int> GiveAnswer;
        public event Action<string> LoadQuiz;
        public event Action<int> GetQuestion;
        #endregion

        #region Events
        private void Question_Click(object sender, EventArgs e)
        {
            Console.WriteLine(SelectedQuestionIndex);
            Button btn = (Button)sender;
            if (GiveAnswer != null)
            {
                GiveAnswer(SelectedQuestionIndex);
                SelectedQuestionIndex = int.Parse(btn.Text) - 1;
                if (GetQuestion != null)
                {
                    GetQuestion(SelectedQuestionIndex);
                }
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
