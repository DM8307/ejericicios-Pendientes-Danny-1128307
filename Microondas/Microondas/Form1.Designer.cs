namespace Microondas
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
            components = new System.ComponentModel.Container();
            pnlPrincipal = new Panel();
            lblpantalla = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnIniciar = new Button();
            btnDetener = new Button();
            btn0 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BorderStyle = BorderStyle.FixedSingle;
            pnlPrincipal.Location = new Point(12, 12);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(282, 249);
            pnlPrincipal.TabIndex = 0;
            // 
            // lblpantalla
            // 
            lblpantalla.BorderStyle = BorderStyle.FixedSingle;
            lblpantalla.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpantalla.Location = new Point(310, 12);
            lblpantalla.Name = "lblpantalla";
            lblpantalla.Size = new Size(237, 50);
            lblpantalla.TabIndex = 1;
            lblpantalla.Text = "00:00:00";
            lblpantalla.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn1
            // 
            btn1.Location = new Point(310, 75);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 39);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(391, 75);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 39);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(472, 75);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 39);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(310, 117);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 39);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(391, 120);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 39);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(472, 117);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 39);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(310, 162);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 39);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(391, 162);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 39);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(472, 162);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 39);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(12, 267);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(138, 34);
            btnIniciar.TabIndex = 11;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(156, 267);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(138, 34);
            btnDetener.TabIndex = 12;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(391, 207);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 39);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 315);
            Controls.Add(btn0);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lblpantalla);
            Controls.Add(pnlPrincipal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private Label lblpantalla;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnIniciar;
        private Button btnDetener;
        private Button btn0;
        private System.Windows.Forms.Timer timer1;
    }
}
