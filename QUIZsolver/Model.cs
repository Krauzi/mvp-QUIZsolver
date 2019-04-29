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
        public Model()
        {
            _quizInstance = new QuizQuestions();
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
                reader.Close();
            }
            Console.WriteLine("dupa");
        }
    }
}
