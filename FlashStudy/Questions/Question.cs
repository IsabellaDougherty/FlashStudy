using System;
using System.Collections.Generic;
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
        public int numAnswers;
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
            numAnswers = a.Length;
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
        /// IAD 3/23/2025 <summary> Returns the figure associated with the question. If the question has multiple figures, the method will return the first figure associated with the question. </summary> <returns></returns>
        public Image GetFigure() { return figure; }
        /// IAD 3/23/2025 <summary>
        /// Returns an array of all figures associated with the question. If only one figure is associated with the question, the array will only contain one element. </summary> <returns></returns>
        public Image[] GetFigures()
        {
            if (multipleFigures) return figures;
            else if (hasFigure) return new Image[] { figure };
            else return null;
        }
        /// IAD 3/23/2025 <summary> Returns the number of figures associated with the question. If no figures are associated with the question, the method will return 0. </summary> <returns></returns>
        public int GetNumFigures() { return figureNames.Length; }
        /// IAD 3/23/2025 <summary> Returns an array of all figure names associated with the question. If only one figure is associated with the question, the array will only contain one element. </summary> <returns></returns> </summary> <returns></returns>
        public string[] GetAnswers() { return answers; }
        /// IAD 3/23/2025 <summary> Returns the explanation for the question. </summary> <returns></returns>
        public string GetExplanation() { return explanation; }
        /// IAD 3/23/2025 <summary> Returns true if the question has a figure associated with it. </summary> <returns></returns>
        public Boolean HasFigure() { return hasFigure; }
        /// IAD 3/23/2025 <summary> Returns true if the question has multiple figures associated with it. </summary> <returns></returns>
        public Boolean IsMultipleFigures() { return multipleFigures; }
        /// IAD 3/21/2025 <summary> Returns the correct answer to the question. </summary> <returns></returns>
        public string GetRightAnswer() { return answers[0]; }
        /// IAD 3/23/2025 <summary> Randomizes the order of the answers to the question. </summary> <returns></returns>
        public string[] RandomizeAnswers()
        {
            List<int> randInts = new List<int>();
            List<string> randAnsList = new List<string>();
            string[] randAns = new string[answers.Length];
            int random;
            //List of 0-answer length and fill it then pull random values
            for (int i = 0; i < answers.Length; i++) { randInts.Add(i); }
            Random rand = new Random();
            while (randInts.Count > 0) 
            { 
                random = rand.Next(0, randInts.Count);
                randAnsList.Add(answers[randInts[random]]);
                randInts.RemoveAt(random);
            }
            randAns = randAnsList.ToArray();
            for (int i = 0; i < randInts.Count; i++) { randAns[i] = answers[randInts[i]]; }
            return randAns;
        }
    }
}
