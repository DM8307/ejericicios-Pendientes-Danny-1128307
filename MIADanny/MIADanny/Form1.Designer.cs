namespace MIADanny
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.txtQuantity24 = new System.Windows.Forms.TextBox();
            this.txtPrice24 = new System.Windows.Forms.TextBox();
            this.txtTotal24 = new System.Windows.Forms.TextBox();
            this.txtTotal27 = new System.Windows.Forms.TextBox();
            this.txtPrice27 = new System.Windows.Forms.TextBox();
            this.txtQuantity27 = new System.Windows.Forms.TextBox();
            this.txtTotal32 = new System.Windows.Forms.TextBox();
            this.txtPrice32 = new System.Windows.Forms.TextBox();
            this.txtQuantity32 = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTaxes = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address* (Line 1):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address (Line 2):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "32\":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "27\":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "24\":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 559);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 485);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Taxes:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 439);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "SubTotal:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(295, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Totals:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(226, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Price:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(155, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Quantity:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(209, 622);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(88, 37);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Caculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(303, 622);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 37);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(189, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Invoice Date:";
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(268, 75);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.ReadOnly = true;
            this.txtInvoiceDate.Size = new System.Drawing.Size(76, 20);
            this.txtInvoiceDate.TabIndex = 18;
            // 
            // txtQuantity24
            // 
            this.txtQuantity24.Location = new System.Drawing.Point(158, 303);
            this.txtQuantity24.Name = "txtQuantity24";
            this.txtQuantity24.Size = new System.Drawing.Size(46, 20);
            this.txtQuantity24.TabIndex = 19;
            this.txtQuantity24.Text = "0";
            this.txtQuantity24.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPrice24
            // 
            this.txtPrice24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPrice24.Location = new System.Drawing.Point(229, 303);
            this.txtPrice24.Name = "txtPrice24";
            this.txtPrice24.ReadOnly = true;
            this.txtPrice24.Size = new System.Drawing.Size(46, 20);
            this.txtPrice24.TabIndex = 20;
            this.txtPrice24.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtTotal24
            // 
            this.txtTotal24.Location = new System.Drawing.Point(298, 303);
            this.txtTotal24.Name = "txtTotal24";
            this.txtTotal24.Size = new System.Drawing.Size(76, 20);
            this.txtTotal24.TabIndex = 21;
            // 
            // txtTotal27
            // 
            this.txtTotal27.Location = new System.Drawing.Point(298, 349);
            this.txtTotal27.Name = "txtTotal27";
            this.txtTotal27.Size = new System.Drawing.Size(76, 20);
            this.txtTotal27.TabIndex = 24;
            // 
            // txtPrice27
            // 
            this.txtPrice27.Location = new System.Drawing.Point(229, 349);
            this.txtPrice27.Name = "txtPrice27";
            this.txtPrice27.ReadOnly = true;
            this.txtPrice27.Size = new System.Drawing.Size(46, 20);
            this.txtPrice27.TabIndex = 23;
            // 
            // txtQuantity27
            // 
            this.txtQuantity27.Location = new System.Drawing.Point(158, 349);
            this.txtQuantity27.Name = "txtQuantity27";
            this.txtQuantity27.Size = new System.Drawing.Size(46, 20);
            this.txtQuantity27.TabIndex = 22;
            this.txtQuantity27.Text = "0";
            // 
            // txtTotal32
            // 
            this.txtTotal32.Location = new System.Drawing.Point(298, 395);
            this.txtTotal32.Name = "txtTotal32";
            this.txtTotal32.Size = new System.Drawing.Size(76, 20);
            this.txtTotal32.TabIndex = 27;
            // 
            // txtPrice32
            // 
            this.txtPrice32.Location = new System.Drawing.Point(229, 392);
            this.txtPrice32.Name = "txtPrice32";
            this.txtPrice32.ReadOnly = true;
            this.txtPrice32.Size = new System.Drawing.Size(46, 20);
            this.txtPrice32.TabIndex = 26;
            // 
            // txtQuantity32
            // 
            this.txtQuantity32.Location = new System.Drawing.Point(158, 392);
            this.txtQuantity32.Name = "txtQuantity32";
            this.txtQuantity32.Size = new System.Drawing.Size(46, 20);
            this.txtQuantity32.TabIndex = 25;
            this.txtQuantity32.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(298, 556);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(76, 20);
            this.txtTotal.TabIndex = 30;
            // 
            // txtTaxes
            // 
            this.txtTaxes.Location = new System.Drawing.Point(298, 479);
            this.txtTaxes.Name = "txtTaxes";
            this.txtTaxes.Size = new System.Drawing.Size(76, 20);
            this.txtTaxes.TabIndex = 29;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(298, 433);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(76, 20);
            this.txtSubTotal.TabIndex = 28;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(132, 75);
            this.txtInvoiceNumber.MaxLength = 4;
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(51, 20);
            this.txtInvoiceNumber.TabIndex = 31;
            this.txtInvoiceNumber.Text = "1234";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(141, 118);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(203, 20);
            this.txtCompanyName.TabIndex = 32;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(141, 164);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(203, 20);
            this.txtAddress1.TabIndex = 33;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(141, 207);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(203, 20);
            this.txtAddress2.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(328, 29);
            this.label16.TabIndex = 35;
            this.label16.Text = "Monitor Invoice Application";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(298, 521);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(76, 20);
            this.txtDiscount.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(226, 524);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Discount 7%:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(131, 592);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(230, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "(Discounts only applys to purchases over $500)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 671);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTaxes);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtTotal32);
            this.Controls.Add(this.txtPrice32);
            this.Controls.Add(this.txtQuantity32);
            this.Controls.Add(this.txtTotal27);
            this.Controls.Add(this.txtPrice27);
            this.Controls.Add(this.txtQuantity27);
            this.Controls.Add(this.txtTotal24);
            this.Controls.Add(this.txtPrice24);
            this.Controls.Add(this.txtQuantity24);
            this.Controls.Add(this.txtInvoiceDate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Monitor Invoice Aplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtInvoiceDate;
        private System.Windows.Forms.TextBox txtQuantity24;
        private System.Windows.Forms.TextBox txtPrice24;
        private System.Windows.Forms.TextBox txtTotal24;
        private System.Windows.Forms.TextBox txtTotal27;
        private System.Windows.Forms.TextBox txtPrice27;
        private System.Windows.Forms.TextBox txtQuantity27;
        private System.Windows.Forms.TextBox txtTotal32;
        private System.Windows.Forms.TextBox txtPrice32;
        private System.Windows.Forms.TextBox txtQuantity32;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTaxes;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}

