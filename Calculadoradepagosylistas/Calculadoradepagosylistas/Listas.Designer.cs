namespace Calculadoradepagosylistas
{
    partial class Listas
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
            lbordenada = new ListBox();
            btnmoverasin = new Button();
            btnmoveraordenada = new Button();
            btnañadirelementolistaordenada = new Button();
            btnborrarelelistaordenada = new Button();
            btnborrarlistaordenada = new Button();
            btnborrarlistasin = new Button();
            btnborrarelementolistasin = new Button();
            btnañadirelementolistasin = new Button();
            lbsinordenar = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbordenada
            // 
            lbordenada.FormattingEnabled = true;
            lbordenada.Items.AddRange(new object[] { "agua", "coco", "contenido", "dedo", "Hola", "oreo", "palma", "queso" });
            lbordenada.Location = new Point(290, 96);
            lbordenada.Name = "lbordenada";
            lbordenada.SelectionMode = SelectionMode.MultiSimple;
            lbordenada.Size = new Size(175, 394);
            lbordenada.Sorted = true;
            lbordenada.TabIndex = 0;
            // 
            // btnmoverasin
            // 
            btnmoverasin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnmoverasin.Location = new Point(211, 211);
            btnmoverasin.Name = "btnmoverasin";
            btnmoverasin.Size = new Size(62, 49);
            btnmoverasin.TabIndex = 2;
            btnmoverasin.Text = "<<";
            btnmoverasin.UseVisualStyleBackColor = true;
            btnmoverasin.Click += btnmoverasin_Click;
            // 
            // btnmoveraordenada
            // 
            btnmoveraordenada.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnmoveraordenada.Location = new Point(211, 298);
            btnmoveraordenada.Name = "btnmoveraordenada";
            btnmoveraordenada.Size = new Size(62, 49);
            btnmoveraordenada.TabIndex = 3;
            btnmoveraordenada.Text = ">>";
            btnmoveraordenada.UseVisualStyleBackColor = true;
            btnmoveraordenada.Click += btnmoveraordenada_Click;
            // 
            // btnañadirelementolistaordenada
            // 
            btnañadirelementolistaordenada.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnañadirelementolistaordenada.Location = new Point(290, 501);
            btnañadirelementolistaordenada.Name = "btnañadirelementolistaordenada";
            btnañadirelementolistaordenada.Size = new Size(175, 23);
            btnañadirelementolistaordenada.TabIndex = 5;
            btnañadirelementolistaordenada.Text = "Añadir Elemento";
            btnañadirelementolistaordenada.UseVisualStyleBackColor = true;
            btnañadirelementolistaordenada.Click += btnañadirelementolistaordenada_Click;
            // 
            // btnborrarelelistaordenada
            // 
            btnborrarelelistaordenada.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnborrarelelistaordenada.Location = new Point(290, 530);
            btnborrarelelistaordenada.Name = "btnborrarelelistaordenada";
            btnborrarelelistaordenada.Size = new Size(175, 23);
            btnborrarelelistaordenada.TabIndex = 8;
            btnborrarelelistaordenada.Text = "Borrar Elementos";
            btnborrarelelistaordenada.UseVisualStyleBackColor = true;
            btnborrarelelistaordenada.Click += btnborrarelelistaordenada_Click;
            // 
            // btnborrarlistaordenada
            // 
            btnborrarlistaordenada.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnborrarlistaordenada.Location = new Point(290, 559);
            btnborrarlistaordenada.Name = "btnborrarlistaordenada";
            btnborrarlistaordenada.Size = new Size(175, 23);
            btnborrarlistaordenada.TabIndex = 9;
            btnborrarlistaordenada.Text = "Borrar Lista";
            btnborrarlistaordenada.UseVisualStyleBackColor = true;
            btnborrarlistaordenada.Click += btnborrarlistaordenada_Click;
            // 
            // btnborrarlistasin
            // 
            btnborrarlistasin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnborrarlistasin.Location = new Point(12, 559);
            btnborrarlistasin.Name = "btnborrarlistasin";
            btnborrarlistasin.Size = new Size(175, 23);
            btnborrarlistasin.TabIndex = 13;
            btnborrarlistasin.Text = "Borrar Lista";
            btnborrarlistasin.UseVisualStyleBackColor = true;
            btnborrarlistasin.Click += btnborrarlistasin_Click;
            // 
            // btnborrarelementolistasin
            // 
            btnborrarelementolistasin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnborrarelementolistasin.Location = new Point(12, 530);
            btnborrarelementolistasin.Name = "btnborrarelementolistasin";
            btnborrarelementolistasin.Size = new Size(175, 23);
            btnborrarelementolistasin.TabIndex = 12;
            btnborrarelementolistasin.Text = "Borrar Elemento";
            btnborrarelementolistasin.UseVisualStyleBackColor = true;
            btnborrarelementolistasin.Click += btnborrarelementolistasin_Click;
            // 
            // btnañadirelementolistasin
            // 
            btnañadirelementolistasin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnañadirelementolistasin.Location = new Point(12, 501);
            btnañadirelementolistasin.Name = "btnañadirelementolistasin";
            btnañadirelementolistasin.Size = new Size(175, 23);
            btnañadirelementolistasin.TabIndex = 11;
            btnañadirelementolistasin.Text = "Añadir Elemento";
            btnañadirelementolistasin.UseVisualStyleBackColor = true;
            btnañadirelementolistasin.Click += btnañadirelementolistasin_Click;
            // 
            // lbsinordenar
            // 
            lbsinordenar.FormattingEnabled = true;
            lbsinordenar.Items.AddRange(new object[] { "Hola", "agua", "coco", "palma", "queso", "dedo", "contenido", "oreo" });
            lbsinordenar.Location = new Point(12, 96);
            lbsinordenar.Name = "lbsinordenar";
            lbsinordenar.Size = new Size(175, 394);
            lbsinordenar.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 14;
            label1.Text = "Lista sin Ordenar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.Location = new Point(290, 38);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 15;
            label2.Text = "Lista Ordenada";
            // 
            // Listas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 601);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnborrarlistasin);
            Controls.Add(btnborrarelementolistasin);
            Controls.Add(btnañadirelementolistasin);
            Controls.Add(lbsinordenar);
            Controls.Add(btnborrarlistaordenada);
            Controls.Add(btnborrarelelistaordenada);
            Controls.Add(btnañadirelementolistaordenada);
            Controls.Add(btnmoveraordenada);
            Controls.Add(btnmoverasin);
            Controls.Add(lbordenada);
            Name = "Listas";
            Text = "Listas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbordenada;
        private Button btnmoverasin;
        private Button btnmoveraordenada;
        private Button btnañadirelementolistaordenada;
        private Button btnborrarelelistaordenada;
        private Button btnborrarlistaordenada;
        private Button btnborrarlistasin;
        private Button btnborrarelementolistasin;
        private Button btnañadirelementolistasin;
        private ListBox lbsinordenar;
        private Label label1;
        private Label label2;
    }
}