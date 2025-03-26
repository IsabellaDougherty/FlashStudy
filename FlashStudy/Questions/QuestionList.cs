using System;
using System.Collections.Generic;
using System.Linq;

namespace FlashStudy.Questions
{
    internal class QuestionList
    {
        public List<Question> questions;
        private string testName;
        public QuestionList(string tN)
        {
            questions = new List<Question>();
            testName = tN;
            ParseQuestions();
        }
        /// IAD 3/23/2025 <summary> Parses the questions from the file and adds them to the list of questions. </summary>
        private void ParseQuestions()
        {
            List<string> allQuestionInformation = GetQuestionFile().Split('\n').ToList<string>();
            string[] questionInformation = new string[4];
            foreach (string overallQuestion in allQuestionInformation)
            {
                questionInformation = overallQuestion.Split('\t');
                string q = questionInformation[0];
                string[] f = questionInformation[1].Split('|');
                string[] a = questionInformation[2].Split('|');
                string[] explanation = questionInformation[3].Split('|');
                string e = "";
                q.Trim();
                foreach (string s in f) { s.Trim(); }
                foreach (string s in a) { s.Trim(); }
                foreach (string s in explanation) 
                {
                    s.Trim();
                    e += "\n" + s; 
                }
                AddQuestion(q, f, a, e);
            }
        }
        /// IAD 3/23/2025 <summary> Gets the question file from the resources. Note the input paramter for the class constructor is the name of the test that will be searched for. </summary>
        /// <param name="testName"></param> <returns></returns>
        private string GetQuestionFile() { return Properties.Resources.ResourceManager.GetString(testName); }
        private void AddQuestion(string q, string[] f, string[] a, string e)
        {
            int figureCount = f.Length;
            Boolean figurePresent = false;
            if (f[0] != "-") { figurePresent = true; }
            if (!figurePresent) { questions.Add(new Question(q, a, e)); }
            else if (figurePresent && figureCount < 2) { questions.Add(new Question(q, f[0], a, e)); }
            else if (figurePresent && figureCount > 1) { questions.Add(new Question(q, f, a, e)); }
        }

        //IAD 3/23/2025: Get methods for the class.
        public Question[] GetQuestionArray() { return questions.ToArray(); }
        public int GetFigureCount(string[] fig)
        {
            if (fig[0] == "-") return 0;
            else return fig.Length;
        }
        //IAD 3/23/2025: Helper Functions
        /// IAD 3/23/2025 <summary>  Randomizes the order of the questions in the list. </summary>
        /// <param name="cleanList"></param> <returns></returns>
        public Question[] RandomizeQuestions(Question[] cleanList)
        {
            List<Question> questionList = cleanList.ToList();
            Question[] randomizedList = new Question[cleanList.Length];
            Random rand = new Random();
            int index = 0;
            while (index < cleanList.Length)
            {
                int randomIndex = rand.Next(0, cleanList.Length);
                randomizedList[index] = questionList[randomIndex];
                questionList.RemoveAt(randomIndex);
                index++;
            }
            return randomizedList;
        }
    }
}
