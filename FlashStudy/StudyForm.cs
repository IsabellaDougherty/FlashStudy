using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashStudy
{
    public partial class StudyForm : Form
    {
        public StudyForm()
        {
            InitializeComponent();
        }
        /// IAD 3/21/2025 <summary> This method is called when the user clicks the "Quit" button, allowing them to exit the study session.
        /// </summary> <param name="sender"></param> <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e) { this.Close(); }
        /// IAD 3/21/2025 <summary> Called when the form is loaded, ensuring everything is proper sizing. </summary> <param name="sender"></param> <param name="e"></param>
        private void StudyForm_Load(object sender, EventArgs e)
        {
            SetLableSizes();
        }
        /// IAD 3/21/2025 <summary> Sets the size of the lable to fit the form based off the user's screen size. </summary>
        private void SetLableSizes()
        {
            Point setPoint = new Point((int)(this.Width / 100), lblQuestion.Location.Y);
            lblQuestion.Location = setPoint;
            lblQuestion.Width = (this.Width - (setPoint.X * 2));
            //MessageBox.Show("Form Width: " + this.Width + "\nLable Width: " + lblQuestion.Width.ToString() + "\nX Coordinate: " + setPoint.X);
            lblQuestion.Height = this.Height - (int)(this.Height / 3);
        }
    }
}
