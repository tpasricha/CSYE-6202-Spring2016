namespace StudentRegistration
{
    partial class NewStudentPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxDeptt = new System.Windows.Forms.ComboBox();
            this.txtBoxLast = new System.Windows.Forms.TextBox();
            this.txtBoxFirst = new System.Windows.Forms.TextBox();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.labelDeptt = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.studentId = new System.Windows.Forms.Label();
            this.studentInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioPart = new System.Windows.Forms.RadioButton();
            this.radioFull = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxDeptt);
            this.panel1.Controls.Add(this.txtBoxLast);
            this.panel1.Controls.Add(this.txtBoxFirst);
            this.panel1.Controls.Add(this.txtBoxId);
            this.panel1.Controls.Add(this.labelDeptt);
            this.panel1.Controls.Add(this.labelLastName);
            this.panel1.Controls.Add(this.labelFirstName);
            this.panel1.Controls.Add(this.studentId);
            this.panel1.Controls.Add(this.studentInfo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 244);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxDeptt
            // 
            this.comboBoxDeptt.FormattingEnabled = true;
            this.comboBoxDeptt.Location = new System.Drawing.Point(88, 190);
            this.comboBoxDeptt.Name = "comboBoxDeptt";
            this.comboBoxDeptt.Size = new System.Drawing.Size(176, 21);
            this.comboBoxDeptt.TabIndex = 9;
            // 
            // txtBoxLast
            // 
            this.txtBoxLast.Location = new System.Drawing.Point(88, 144);
            this.txtBoxLast.Name = "txtBoxLast";
            this.txtBoxLast.Size = new System.Drawing.Size(176, 20);
            this.txtBoxLast.TabIndex = 8;
            // 
            // txtBoxFirst
            // 
            this.txtBoxFirst.Location = new System.Drawing.Point(88, 97);
            this.txtBoxFirst.Name = "txtBoxFirst";
            this.txtBoxFirst.Size = new System.Drawing.Size(176, 20);
            this.txtBoxFirst.TabIndex = 7;
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(88, 50);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(176, 20);
            this.txtBoxId.TabIndex = 6;
            this.txtBoxId.TextChanged += new System.EventHandler(this.txtBoxId_TextChanged);
            // 
            // labelDeptt
            // 
            this.labelDeptt.AutoSize = true;
            this.labelDeptt.Location = new System.Drawing.Point(8, 198);
            this.labelDeptt.Name = "labelDeptt";
            this.labelDeptt.Size = new System.Drawing.Size(62, 13);
            this.labelDeptt.TabIndex = 5;
            this.labelDeptt.Text = "Department";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(8, 147);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(8, 97);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "First Name";
            // 
            // studentId
            // 
            this.studentId.AutoSize = true;
            this.studentId.Location = new System.Drawing.Point(8, 53);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(56, 13);
            this.studentId.TabIndex = 2;
            this.studentId.Text = "Student Id";
            // 
            // studentInfo
            // 
            this.studentInfo.AutoSize = true;
            this.studentInfo.Location = new System.Drawing.Point(22, 0);
            this.studentInfo.Name = "studentInfo";
            this.studentInfo.Size = new System.Drawing.Size(65, 13);
            this.studentInfo.TabIndex = 1;
            this.studentInfo.Text = "Student Info";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioPart);
            this.panel2.Controls.Add(this.radioFull);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(287, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 132);
            this.panel2.TabIndex = 0;
            // 
            // radioPart
            // 
            this.radioPart.AutoSize = true;
            this.radioPart.Location = new System.Drawing.Point(124, 46);
            this.radioPart.Name = "radioPart";
            this.radioPart.Size = new System.Drawing.Size(70, 17);
            this.radioPart.TabIndex = 2;
            this.radioPart.TabStop = true;
            this.radioPart.Text = "Part Time";
            this.radioPart.UseVisualStyleBackColor = true;
            // 
            // radioFull
            // 
            this.radioFull.AutoSize = true;
            this.radioFull.Location = new System.Drawing.Point(27, 46);
            this.radioFull.Name = "radioFull";
            this.radioFull.Size = new System.Drawing.Size(67, 17);
            this.radioFull.TabIndex = 1;
            this.radioFull.TabStop = true;
            this.radioFull.Text = "Full Time";
            this.radioFull.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employment Type";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(278, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(387, 341);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 36);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // NewStudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(503, 421);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewStudentPage";
            this.Text = "NewStudentPage";
            this.Load += new System.EventHandler(this.NewStudentPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxDeptt;
        private System.Windows.Forms.TextBox txtBoxLast;
        private System.Windows.Forms.TextBox txtBoxFirst;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label labelDeptt;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label studentId;
        private System.Windows.Forms.Label studentInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioPart;
        private System.Windows.Forms.RadioButton radioFull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
    }
}