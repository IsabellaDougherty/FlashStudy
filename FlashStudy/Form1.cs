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
    public partial class FigureForm : Form
    {
        private string figure;
        public FigureForm(string f)
        {
            figure = f;
            InitializeComponent();
        }

        private void FigureForm_Load(object sender, EventArgs e)
        {
            this.Text = figure;
            this.BackgroundImage = Properties.Resources.ResourceManager.GetObject(figure) as Image;
            int width = this.BackgroundImage.Width;
            int height = this.BackgroundImage.Height;
            this.Size = new Size(width, height);
        }
    }
}
