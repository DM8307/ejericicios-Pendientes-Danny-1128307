namespace App_informe_de_Ventas
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
            groupBox1 = new GroupBox();
            btnSubmit = new Button();
            txtFriday = new TextBox();
            txtThursday = new TextBox();
            txtWednesday = new TextBox();
            txtTuesday = new TextBox();
            txtMonday = new TextBox();
            label6 = new Label();
            txtItem = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblTotalSales = new Label();
            lvSales = new ListView();
            label9 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(txtFriday);
            groupBox1.Controls.Add(txtThursday);
            groupBox1.Controls.Add(txtWednesday);
            groupBox1.Controls.Add(txtTuesday);
            groupBox1.Controls.Add(txtMonday);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtItem);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(37, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(233, 343);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Item";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(80, 299);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(145, 23);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit Item";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtFriday
            // 
            txtFriday.Location = new Point(127, 245);
            txtFriday.Name = "txtFriday";
            txtFriday.Size = new Size(100, 23);
            txtFriday.TabIndex = 11;
            // 
            // txtThursday
            // 
            txtThursday.Location = new Point(127, 202);
            txtThursday.Name = "txtThursday";
            txtThursday.Size = new Size(100, 23);
            txtThursday.TabIndex = 10;
            // 
            // txtWednesday
            // 
            txtWednesday.Location = new Point(127, 156);
            txtWednesday.Name = "txtWednesday";
            txtWednesday.Size = new Size(100, 23);
            txtWednesday.TabIndex = 9;
            // 
            // txtTuesday
            // 
            txtTuesday.Location = new Point(127, 115);
            txtTuesday.Name = "txtTuesday";
            txtTuesday.Size = new Size(100, 23);
            txtTuesday.TabIndex = 8;
            // 
            // txtMonday
            // 
            txtMonday.Location = new Point(127, 67);
            txtMonday.Name = "txtMonday";
            txtMonday.Size = new Size(100, 23);
            txtMonday.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 34);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 6;
            label6.Text = "Item:";
            // 
            // txtItem
            // 
            txtItem.Location = new Point(80, 26);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(147, 23);
            txtItem.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 253);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Friday:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 205);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Thursday:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 118);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Tuesday:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 159);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Wednesday:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 75);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Monday:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(312, 46);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 1;
            label7.Text = "Itemized Sales:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(719, 345);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 3;
            label8.Text = "Gross Sales:";
            // 
            // lblTotalSales
            // 
            lblTotalSales.BorderStyle = BorderStyle.Fixed3D;
            lblTotalSales.Location = new Point(817, 337);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(100, 23);
            lblTotalSales.TabIndex = 4;
            lblTotalSales.Click += lblTotalSales_Click;
            // 
            // lvSales
            // 
            lvSales.Location = new Point(312, 70);
            lvSales.Name = "lvSales";
            lvSales.Size = new Size(605, 227);
            lvSales.TabIndex = 5;
            lvSales.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(155, 15);
            label9.TabIndex = 6;
            label9.Text = "Danny Mendoza ID: 1128307";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 393);
            Controls.Add(label9);
            Controls.Add(lvSales);
            Controls.Add(lblTotalSales);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Sales Report";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox txtItem;
        private Label label5;
        private Button btnSubmit;
        private TextBox txtFriday;
        private TextBox txtThursday;
        private TextBox txtWednesday;
        private TextBox txtTuesday;
        private TextBox txtMonday;
        private Label label7;
        private Label label8;
        private Label lblTotalSales;
        private ListView lvSales;
        private Label label9;
    }
}
