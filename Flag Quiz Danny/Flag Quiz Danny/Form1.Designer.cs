namespace Flag_Quiz_Danny
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            cmbCountries = new ComboBox();
            btnSubmit = new Button();
            btnNext = new Button();
            txtFeedback = new TextBox();
            txtFinalScore = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(14, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cmbCountries
            // 
            cmbCountries.FlatStyle = FlatStyle.Popup;
            cmbCountries.FormattingEnabled = true;
            cmbCountries.Location = new Point(219, 51);
            cmbCountries.Name = "cmbCountries";
            cmbCountries.Size = new Size(121, 23);
            cmbCountries.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Location = new Point(353, 20);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 34);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnNext
            // 
            btnNext.Enabled = false;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Location = new Point(353, 60);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 33);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtFeedback
            // 
            txtFeedback.BorderStyle = BorderStyle.FixedSingle;
            txtFeedback.Location = new Point(219, 99);
            txtFeedback.Name = "txtFeedback";
            txtFeedback.ReadOnly = true;
            txtFeedback.Size = new Size(122, 23);
            txtFeedback.TabIndex = 4;
            // 
            // txtFinalScore
            // 
            txtFinalScore.BorderStyle = BorderStyle.FixedSingle;
            txtFinalScore.Location = new Point(353, 99);
            txtFinalScore.Name = "txtFinalScore";
            txtFinalScore.ReadOnly = true;
            txtFinalScore.Size = new Size(75, 23);
            txtFinalScore.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 116);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Flag";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 20);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 7;
            label1.Text = "Select Country:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 148);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(txtFinalScore);
            Controls.Add(txtFeedback);
            Controls.Add(btnNext);
            Controls.Add(btnSubmit);
            Controls.Add(cmbCountries);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cmbCountries;
        private Button btnSubmit;
        private Button btnNext;
        private TextBox txtFeedback;
        private TextBox txtFinalScore;
        private GroupBox groupBox1;
        private Label label1;
    }
}
