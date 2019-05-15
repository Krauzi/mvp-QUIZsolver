using QUIZsolver.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Web.Script.Serialization;

namespace QUIZsolver
{
    class Model
    {
        private QuizQuestions _quizInstance;
        private QuizQuestions _quizLoad;

        public Model()
        {
            _quizInstance = new QuizQuestions();  // to jest obiekt quizu, który rozwiązuje użytkownik
            _quizLoad = new QuizQuestions();
        }

        public List<Tuple<string, uint, List<Tuple<string, bool>>>> GetQuestions
        {
            get
            {
                return _quizInstance.GetQuestions();
            }
        }
        public List<Tuple<string, bool>> GetAnswers(int givenQuestionIndex)
        {
            return _quizInstance.Questions[givenQuestionIndex].GetQuestion().Item3;
        }

        public Tuple<string, uint, List<Tuple<string, bool>>> GetQuestionData(int givenQuestionIndex)
        {
            return _quizInstance.Questions[givenQuestionIndex].GetQuestion();
        }

        public void GiveAnswer(int givenQuestionIndex, List<Tuple<string, bool>> Answers)
        {
            _quizInstance.Questions[givenQuestionIndex].Update(Answers);
        }

        public void LoadQuiz(string fileName)
        {
            if (fileName.EndsWith(".json"))
            {
                using (StreamReader inputFile = new StreamReader(Path.Combine(fileName)))
                {
                    string inputJson = inputFile.ReadToEnd();

                    try
                    {
                        _quizInstance = new JavaScriptSerializer().Deserialize<QuizQuestions>(inputJson);
                        _quizLoad = new JavaScriptSerializer().Deserialize<QuizQuestions>(inputJson);
                        ClearAnswers(_quizInstance);
                    }
                    catch (Exception)
                    {
                        throw new Exception("Failed to open file");
                    }
                }
            }
            else
            {
                Console.WriteLine(fileName);
                XmlSerializer deserializer = new XmlSerializer(typeof(QuizQuestions));
                TextReader reader = new StreamReader(Path.Combine(fileName));
                object obj = deserializer.Deserialize(reader);
                _quizInstance = (QuizQuestions)obj;
                _quizLoad = (QuizQuestions)obj;
                ClearAnswers(_quizInstance);
                reader.Close();
            }
        }

        private void ClearAnswers(QuizQuestions quizInstance)
        {
            for (int i = 0; i < quizInstance.Questions.Count; i++)
            {
                for (int j = 0; j < quizInstance.Questions[i].Answers.Count; j++)
                    quizInstance.Questions[i].Answers[j].IsCorrect = false;
            }
        }

        public void DisplayScore()
        {
            uint points = 0;

            Console.WriteLine($"Przed dodaniem do instancji [load, instancja]: [{_quizLoad.TotalPoints}, {_quizInstance.TotalPoints}]");
            _quizInstance.TotalPoints += 5;
            Console.WriteLine($"Po dodaniu do instancji [load, instancja]: [{_quizLoad.TotalPoints}, {_quizInstance.TotalPoints}]");

            for (int i = 0; i < _quizInstance.Questions.Count; i++)
            {
                //Console.WriteLine($"Question {i}");
                for(int j = 0; j < _quizInstance.Questions[i].Answers.Count; j++)
                {
                    if(_quizInstance.Questions[i].Answers[j].IsCorrect == _quizLoad.Questions[i].Answers[j].IsCorrect && _quizLoad.Questions[i].Answers[j].IsCorrect)
                    {
                        Console.WriteLine($"\tLoad : {_quizLoad.Questions[i].Answers[j].IsCorrect} <===> {_quizInstance.Questions[i].Answers[j].IsCorrect} : Instance");
                        points += _quizLoad.Questions[i].QuestionPoints;
                    }
                }
            }

            Console.WriteLine(points);

            Form3 score = new Form3(points);
            score.Show();
        }
    }
}
