using FlashStudy.Questions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FlashStudy
{
    public partial class StudyForm : Form
    {
        /// IAD 3/23/2025 <summary> This class is used to allow the user to study the questions in the test they selected. </summary>
        private List<Question> correct = new List<Question>();
        private List<Question> incorrect = new List<Question>();
        private QuestionList questionList = new QuestionList("General");
        private Question currentQuestion;
        private string pickedAnswer = "No answer selected";
        private string correctAnswer = "No question input";

        // Tester variables
        /*private static string[] testerAnswerString = new string[] { "Correct Answer", "Incorrect Answer 1", "Incorrect Answer 2" };
        private Question testerQuestionNoFigure = new Question("This is a tester question to see if things are working as expected.",
            testerAnswerString, "This is a fake explanation to see if the explanation section is working as expected.");
        private Question secondTesterQuestionNoFigure = new Question("This is a follow up question to see if things are working as expected.",
            testerAnswerString, "This is a second fake explanation to see if the explanation section is working as expected.");*/

        /// IAD 3/23/2025 <summary> Constructor for the StudyForm class, initializing the form. </summary>
        public StudyForm()
        {
            InitializeComponent();
        }
        /// IAD 3/21/2025 <summary> This method is called when the user clicks the "Quit" button, allowing them to exit the study session. </summary> <param name="sender"></param> <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e) { this.Close(); }
        /// IAD 3/21/2025 <summary> Called when the form is loaded, ensuring everything is proper sizing. </summary> <param name="sender"></param> <param name="e"></param>
        private void StudyForm_Load(object sender, EventArgs e)
        {
            SetLableSizes();
            SetButtonLocation();
            currentQuestion = questionList.questions[0];
            LoadQuestion(currentQuestion);
        }
        /// IAD 3/23/2025 <summary> This method is called when the user clicks the "Next" button, allowing them to move to the next question. </summary> <param name="sender"></param> <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnAns1.Checked || btnAns2.Checked || btnAns3.Checked)
            {
                string result;
                if(btnAns1.Checked) pickedAnswer = btnAns1.Text;
                if(btnAns2.Checked) pickedAnswer = btnAns2.Text;
                if(btnAns3.Checked) pickedAnswer = btnAns3.Text;
                if (EvaluateAnswer()) result = "Correct!";
                else result = "Incorrect!";
                btnNext.Enabled = true;
                btnNext.Visible = true;
                ColorAnswers(true);
                MessageBox.Show(result + "\n\n" + currentQuestion.explanation);
            }
        }
        /// IAD 3/23/2025 <summary> This method is called when the user clicks the "Next" button, allowing them to move to the next question. </summary> </summary> <param name="sender"></param> <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            pickedAnswer = "No answer selected";
            correctAnswer = "No question input";
            btnNext.Enabled = false;
            btnNext.Visible = false;
            ColorAnswers(false);
            UncheckButtons();
            int nextQuestionCheck = questionList.questions.IndexOf(currentQuestion);
            if (nextQuestionCheck < questionList.questions.Count - 1)
            {
                currentQuestion = questionList.questions[questionList.questions.IndexOf(currentQuestion) + 1];
                LoadQuestion(currentQuestion);
            }
            else { MessageBox.Show("You have completed the test!"); this.Close(); }
        }
        /// IAD 3/23/2025 <summary> This method is called when the user clicks the "Next" button, allowing them to move to the next question. </summary> <param name="question"></param>
        private void LoadQuestion(Question question)
        {
            currentQuestion = question;
            lblQuestion.Text = question.question;
            correctAnswer = currentQuestion.GetRightAnswer();
            SetQuestionText();
        }
        /// IAD 3/23/2025 <summary> This method is called when the user clicks the "Next" button, allowing them to move to the next question. </summary> <returns></returns>
        private Boolean EvaluateAnswer()
        {
            if (pickedAnswer == correctAnswer)
            {
                correct.Add(currentQuestion);
                return true;
            }
            if (pickedAnswer != correctAnswer)
            {
                incorrect.Add(currentQuestion);
                return false;
            }
            return false;
        }
        /// IAD 3/23/2025 <summary> This method is called when the user clicks the "Next" button, allowing them to move to the next question. </summary>
        private void ColorAnswers(Boolean color)
        {
            if (color)
            {
                if (btnAns1.Text == correctAnswer) { btnAns1.BackColor = Color.Green; }
                else btnAns1.BackColor = Color.Red;
                if (btnAns2.Text == correctAnswer) { btnAns2.BackColor = Color.Green; }
                else btnAns2.BackColor = Color.Red;
                if (btnAns3.Text == correctAnswer) { btnAns3.BackColor = Color.Green; }
                else btnAns3.BackColor = Color.Red;
            }
            else
            {
                btnAns1.BackColor = SystemColors.ControlDark;
                btnAns2.BackColor = SystemColors.ControlDark;
                btnAns3.BackColor = SystemColors.ControlDark;
            }
        }
        /// IAD 3/21/2025 <summary> Sets the size of the lable to fit the form based off the user's screen size. </summary>
        private void SetLableSizes()
        {
            Point setPoint = new Point((int)(this.Width / 100), lblQuestion.Location.Y);
            lblQuestion.Location = setPoint;
            lblQuestion.Width = (this.Width - (setPoint.X * 2));
            lblQuestion.Height = this.Height - (int)(this.Height / 3);
        }
        /// IAD 3/23/2025 <summary> Sets the location of the button to the bottom right of the form. </summary>
        private void SetButtonLocation() { btnNext.Location = new Point(lblQuestion.Right - btnNext.Width, lblQuestion.Bottom); }
        /// IAD 3/25/2025 <summary> Sets the text of the answer options to the randomized answers. </summary>
        private void SetQuestionText()
        {
            lblQuestion.Text = currentQuestion.question;
            string[] randomizedAnswers = currentQuestion.RandomizeAnswers();
            btnAns1.Text = randomizedAnswers[0];
            btnAns2.Text = randomizedAnswers[1];
            btnAns3.Text = randomizedAnswers[2];
        }
        /// IAD 3/25/2025 <summary> Unchecks all the buttons. </summary>
        private void UncheckButtons()
        {
            btnAns1.Checked = false;
            btnAns2.Checked = false;
            btnAns3.Checked = false;
        }
    }
}
