namespace Calculadoradepagosylistas
{
    partial class Calculadoradepagos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            chkpagosanticipados = new CheckBox();
            txtValoraTomar = new TextBox();
            txtCantidaddeMeses = new TextBox();
            txtTasadeinteres = new TextBox();
            btnCalcularpagos = new Button();
            txtPagosMensuales = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 9);
            label1.Name = "label1";
            label1.Size = new Size(341, 45);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de Pagos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 83);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor a Tomar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 122);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad de Meses";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 165);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 3;
            label4.Text = "Tasa de interes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 294);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 4;
            label5.Text = "Pagos Mensuales:";
            // 
            // chkpagosanticipados
            // 
            chkpagosanticipados.AutoSize = true;
            chkpagosanticipados.Location = new Point(46, 213);
            chkpagosanticipados.Name = "chkpagosanticipados";
            chkpagosanticipados.Size = new Size(122, 19);
            chkpagosanticipados.TabIndex = 5;
            chkpagosanticipados.Text = "Pagos anticipados";
            chkpagosanticipados.UseVisualStyleBackColor = true;
            // 
            // txtValoraTomar
            // 
            txtValoraTomar.Location = new Point(202, 83);
            txtValoraTomar.Name = "txtValoraTomar";
            txtValoraTomar.Size = new Size(185, 23);
            txtValoraTomar.TabIndex = 6;
            txtValoraTomar.Text = "0.00";
            // 
            // txtCantidaddeMeses
            // 
            txtCantidaddeMeses.Location = new Point(202, 122);
            txtCantidaddeMeses.Name = "txtCantidaddeMeses";
            txtCantidaddeMeses.Size = new Size(185, 23);
            txtCantidaddeMeses.TabIndex = 7;
            txtCantidaddeMeses.Text = "0";
            // 
            // txtTasadeinteres
            // 
            txtTasadeinteres.Location = new Point(202, 165);
            txtTasadeinteres.Name = "txtTasadeinteres";
            txtTasadeinteres.Size = new Size(185, 23);
            txtTasadeinteres.TabIndex = 8;
            txtTasadeinteres.Text = "0.00";
            // 
            // btnCalcularpagos
            // 
            btnCalcularpagos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcularpagos.Location = new Point(46, 329);
            btnCalcularpagos.Name = "btnCalcularpagos";
            btnCalcularpagos.Size = new Size(341, 51);
            btnCalcularpagos.TabIndex = 9;
            btnCalcularpagos.Text = "Calcular pagos";
            btnCalcularpagos.UseVisualStyleBackColor = true;
            btnCalcularpagos.Click += btnCalcularpagos_Click;
            // 
            // txtPagosMensuales
            // 
            txtPagosMensuales.Location = new Point(202, 291);
            txtPagosMensuales.Name = "txtPagosMensuales";
            txtPagosMensuales.Size = new Size(185, 23);
            txtPagosMensuales.TabIndex = 10;
            // 
            // Calculadoradepagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 450);
            Controls.Add(txtPagosMensuales);
            Controls.Add(btnCalcularpagos);
            Controls.Add(txtTasadeinteres);
            Controls.Add(txtCantidaddeMeses);
            Controls.Add(txtValoraTomar);
            Controls.Add(chkpagosanticipados);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Calculadoradepagos";
            Text = "Calculadoradepagos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox chkpagosanticipados;
        private TextBox txtValoraTomar;
        private TextBox txtCantidaddeMeses;
        private TextBox txtTasadeinteres;
        private Button btnCalcularpagos;
        private TextBox txtPagosMensuales;
    }
}