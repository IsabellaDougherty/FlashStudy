using System;
using System.Drawing;
using System.Linq;

namespace FlashStudy.Questions
{
    internal class Question
    {
        /// IAD 3/21/2025 <summary> This class is used to store the information for a question, including the question, figure, answers, and explanation. </summary>
        public string question;
        private string figureName;
        private string[] figureNames;
        public string[] answers;
        public string explanation;
        public Image figure;
        public Image[] figures;
        public Boolean hasFigure;
        public Boolean multipleFigures;
        /// IAD 3/21/2025 <summary> Constructor for the Question class, setting the question, answers, and explanation. </summary> <param name="q"></param> <param name="a"></param> <param name="explain"></param>
        public Question(string q, string[] a, string explain)
        {
            question = q; explanation = explain;
            answers = new string[a.Length]; answers = a;
            hasFigure = false;
            multipleFigures = false;
        }
        /// IAD 3/21/2025 <summary> Constructor for the Question class, setting the question, figure, answers, and explanation. </summary> <param name="q"></param> <param name="f"></param> <param name="a"></param> <param name="explain"></param>
        public Question(string q, string f, string[] a, string explain)
        {
            question = q; explanation = explain;
            answers = new string[a.Length]; answers = a;
            figureName = f;
            hasFigure = true;
            multipleFigures = false;
            SetFigure();
        }
        /// IAD 3/21/2025 <summary>  Constructor for the Question class, setting the question, figures, answers, and explanation. </summary> <param name="q"></param> <param name="f"></param> <param name="a"></param> <param name="explain"></param>
        public Question(string q, string[] f, string[] a, string explain)
        {
            question = q; explanation = explain;
            answers = new string[a.Length]; answers = a;
            for (int i = 0; i < f.Length; i++) { figureNames[i] = f[i]; }
            hasFigure = true;
            multipleFigures = true;
            SetFigures();
        }
        /// IAD 3/21/2025 <summary> Sets the figure for the question if a figure is present. </summary>
        public void SetFigure() { if (hasFigure) { figure = Properties.Resources.ResourceManager.GetObject(figureName) as Image; } }
        /// IAD 3/21/2025 <summary> Sets the figure for the question if a figure is present. </summary>
        public void SetFigures()
        {
            if (hasFigure)
            {
                int index = 0;
                foreach (string s in figureNames)
                {
                    figures[index] = Properties.Resources.ResourceManager.GetObject(figureNames[index]) as Image;
                    index++;
                }
            }
        }
        // IAD 3/21/2025: Get methods for the class.
        public string GetQuestion() { return question; }
        public Image GetFigure() { return figure; }
        public Image[] GetFigures() { if (multipleFigures) return figures; else return null; }
        public string[] GetAnswers() { return answers; }
        public string GetExplanation() { return explanation; }
        public Boolean HasFigure() { return hasFigure; }
        public Boolean IsMultipleFigures() { return multipleFigures; }
        /// IAD 3/21/2025 <summary> Returns the correct answer to the question. </summary> <returns></returns>
        public string GetRightAnswer() { return answers[0]; }
    }
}
