namespace ShippinghubDanny
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
            lblArriveAt = new Label();
            txtArrivedat = new TextBox();
            groupBox1 = new GroupBox();
            cmbStateI = new ComboBox();
            txtZip = new TextBox();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            lblZip = new Label();
            lblState = new Label();
            lblCity = new Label();
            lblAddress = new Label();
            lblPackageNumber = new Label();
            groupBox2 = new GroupBox();
            lstPackages = new ListBox();
            cmbState = new ComboBox();
            txtPackageNumber = new TextBox();
            btnback = new Button();
            btnScanNew = new Button();
            btnAdd = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            btnNext = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblArriveAt
            // 
            lblArriveAt.AutoSize = true;
            lblArriveAt.Location = new Point(12, 23);
            lblArriveAt.Name = "lblArriveAt";
            lblArriveAt.Size = new Size(56, 15);
            lblArriveAt.TabIndex = 0;
            lblArriveAt.Text = "Arrive At:";
            // 
            // txtArrivedat
            // 
            txtArrivedat.Location = new Point(128, 23);
            txtArrivedat.Name = "txtArrivedat";
            txtArrivedat.ReadOnly = true;
            txtArrivedat.Size = new Size(241, 23);
            txtArrivedat.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbStateI);
            groupBox1.Controls.Add(txtZip);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(lblZip);
            groupBox1.Controls.Add(lblState);
            groupBox1.Controls.Add(lblCity);
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(lblPackageNumber);
            groupBox1.Location = new Point(23, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(609, 301);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Packge Information";
            // 
            // cmbStateI
            // 
            cmbStateI.FormattingEnabled = true;
            cmbStateI.Items.AddRange(new object[] { "AL", "FL", "GA", "KY", "MS", "NC", "SC", "TN", "WV", "VA" });
            cmbStateI.Location = new Point(320, 212);
            cmbStateI.Name = "cmbStateI";
            cmbStateI.Size = new Size(86, 23);
            cmbStateI.TabIndex = 2;
            // 
            // txtZip
            // 
            txtZip.Location = new Point(495, 212);
            txtZip.MaxLength = 5;
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(77, 23);
            txtZip.TabIndex = 8;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(105, 212);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(142, 23);
            txtCity.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(105, 136);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 5;
            // 
            // lblZip
            // 
            lblZip.AutoSize = true;
            lblZip.Location = new Point(428, 220);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(27, 15);
            lblZip.TabIndex = 4;
            lblZip.Text = "Zip:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(278, 220);
            lblState.Name = "lblState";
            lblState.Size = new Size(36, 15);
            lblState.TabIndex = 3;
            lblState.Text = "State:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(18, 220);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 15);
            lblCity.TabIndex = 2;
            lblCity.Text = "City:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(18, 144);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address:";
            // 
            // lblPackageNumber
            // 
            lblPackageNumber.AutoSize = true;
            lblPackageNumber.Location = new Point(18, 69);
            lblPackageNumber.Name = "lblPackageNumber";
            lblPackageNumber.Size = new Size(68, 15);
            lblPackageNumber.TabIndex = 0;
            lblPackageNumber.Text = "Package ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstPackages);
            groupBox2.Controls.Add(cmbState);
            groupBox2.Location = new Point(667, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(218, 301);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Packages by State";
            // 
            // lstPackages
            // 
            lstPackages.FormattingEnabled = true;
            lstPackages.Location = new Point(21, 78);
            lstPackages.Name = "lstPackages";
            lstPackages.Size = new Size(179, 199);
            lstPackages.TabIndex = 1;
            // 
            // cmbState
            // 
            cmbState.FormattingEnabled = true;
            cmbState.Items.AddRange(new object[] { "AL", "FL", "GA", "KY", "MS", "NC", "SC", "TN", "WV", "VA" });
            cmbState.Location = new Point(21, 31);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(179, 23);
            cmbState.TabIndex = 0;
            cmbState.SelectedIndexChanged += cmbState_SelectedIndexChanged;
            // 
            // txtPackageNumber
            // 
            txtPackageNumber.Location = new Point(128, 141);
            txtPackageNumber.Name = "txtPackageNumber";
            txtPackageNumber.ReadOnly = true;
            txtPackageNumber.Size = new Size(467, 23);
            txtPackageNumber.TabIndex = 4;
            // 
            // btnback
            // 
            btnback.Location = new Point(41, 401);
            btnback.Name = "btnback";
            btnback.Size = new Size(96, 37);
            btnback.TabIndex = 5;
            btnback.Text = "< BACK";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnScanNew
            // 
            btnScanNew.Location = new Point(143, 401);
            btnScanNew.Name = "btnScanNew";
            btnScanNew.Size = new Size(96, 37);
            btnScanNew.TabIndex = 6;
            btnScanNew.Text = "Scan New";
            btnScanNew.UseVisualStyleBackColor = true;
            btnScanNew.Click += btnScanNew_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(245, 401);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 37);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(347, 401);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(96, 37);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(451, 401);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(96, 37);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(553, 401);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(96, 37);
            btnNext.TabIndex = 10;
            btnNext.Text = "NEXT >";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 450);
            Controls.Add(btnNext);
            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(btnScanNew);
            Controls.Add(btnback);
            Controls.Add(txtPackageNumber);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblArriveAt);
            Controls.Add(txtArrivedat);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArriveAt;
        private TextBox txtArrivedat;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox lstPackages;
        private ComboBox cmbState;
        private Label lblZip;
        private Label lblState;
        private Label lblCity;
        private Label lblAddress;
        private Label lblPackageNumber;
        private TextBox txtPackageNumber;
        private TextBox txtZip;
        private TextBox txtCity;
        private TextBox txtAddress;
        private ComboBox cmbStateI;
        private Button btnback;
        private Button btnScanNew;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnNext;
    }
}
