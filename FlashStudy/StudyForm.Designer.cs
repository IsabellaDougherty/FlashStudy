namespace FlashStudy
{
    partial class StudyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyForm));
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAns1 = new System.Windows.Forms.RadioButton();
            this.tblLayPanAns = new System.Windows.Forms.TableLayoutPanel();
            this.btnAns3 = new System.Windows.Forms.RadioButton();
            this.btnAns2 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNext = new CustomControls.ImageShapedButton();
            this.tblLayPanAns.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestion.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(0, 70);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(335, 374);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question Text";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(334, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAns1
            // 
            this.btnAns1.AutoSize = true;
            this.btnAns1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAns1.FlatAppearance.BorderSize = 0;
            this.btnAns1.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue;
            this.btnAns1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAns1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAns1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAns1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns1.Location = new System.Drawing.Point(3, 3);
            this.btnAns1.Name = "btnAns1";
            this.btnAns1.Size = new System.Drawing.Size(353, 60);
            this.btnAns1.TabIndex = 2;
            this.btnAns1.TabStop = true;
            this.btnAns1.Text = "Answer 1";
            this.btnAns1.UseVisualStyleBackColor = true;
            // 
            // tblLayPanAns
            // 
            this.tblLayPanAns.ColumnCount = 1;
            this.tblLayPanAns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayPanAns.Controls.Add(this.btnAns3, 0, 2);
            this.tblLayPanAns.Controls.Add(this.btnAns2, 0, 1);
            this.tblLayPanAns.Controls.Add(this.btnAns1, 0, 0);
            this.tblLayPanAns.Controls.Add(this.btnSubmit, 0, 3);
            this.tblLayPanAns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblLayPanAns.Location = new System.Drawing.Point(0, 540);
            this.tblLayPanAns.Name = "tblLayPanAns";
            this.tblLayPanAns.RowCount = 4;
            this.tblLayPanAns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.33283F));
            this.tblLayPanAns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.33283F));
            this.tblLayPanAns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.33283F));
            this.tblLayPanAns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0015F));
            this.tblLayPanAns.Size = new System.Drawing.Size(359, 233);
            this.tblLayPanAns.TabIndex = 3;
            // 
            // btnAns3
            // 
            this.btnAns3.AutoSize = true;
            this.btnAns3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAns3.FlatAppearance.BorderSize = 0;
            this.btnAns3.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue;
            this.btnAns3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAns3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAns3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAns3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns3.Location = new System.Drawing.Point(3, 135);
            this.btnAns3.Name = "btnAns3";
            this.btnAns3.Size = new System.Drawing.Size(353, 60);
            this.btnAns3.TabIndex = 4;
            this.btnAns3.TabStop = true;
            this.btnAns3.Text = "Answer 3";
            this.btnAns3.UseVisualStyleBackColor = true;
            // 
            // btnAns2
            // 
            this.btnAns2.AutoSize = true;
            this.btnAns2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAns2.FlatAppearance.BorderSize = 0;
            this.btnAns2.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue;
            this.btnAns2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAns2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAns2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAns2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns2.Location = new System.Drawing.Point(3, 69);
            this.btnAns2.Name = "btnAns2";
            this.btnAns2.Size = new System.Drawing.Size(353, 60);
            this.btnAns2.TabIndex = 3;
            this.btnAns2.TabStop = true;
            this.btnAns2.Text = "Answer 2";
            this.btnAns2.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Location = new System.Drawing.Point(3, 201);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(353, 29);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit Answer";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::FlashStudy.Properties.Resources.Untitled_Artwork;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.ButtonImage = global::FlashStudy.Properties.Resources.Untitled_Artwork;
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(214, 447);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(145, 87);
            this.btnNext.TabIndex = 4;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // StudyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(359, 773);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tblLayPanAns);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Study Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudyForm_Load);
            this.tblLayPanAns.ResumeLayout(false);
            this.tblLayPanAns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton btnAns1;
        private System.Windows.Forms.TableLayoutPanel tblLayPanAns;
        private System.Windows.Forms.RadioButton btnAns3;
        private System.Windows.Forms.RadioButton btnAns2;
        private System.Windows.Forms.Button btnSubmit;
        private CustomControls.ImageShapedButton btnNext;
    }
}

