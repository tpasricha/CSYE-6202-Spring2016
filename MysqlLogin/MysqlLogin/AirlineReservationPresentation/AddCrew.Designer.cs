namespace MysqlLogin.AirlineReservationPresentation
{
    partial class AddCrew
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
            this.lblCrewId = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCrewId = new System.Windows.Forms.TextBox();
            this.textBoxCrewMembers = new System.Windows.Forms.TextBox();
            this.lblFlighhtNumber = new System.Windows.Forms.Label();
            this.textBoxFlightNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCrewId
            // 
            this.lblCrewId.AutoSize = true;
            this.lblCrewId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrewId.Location = new System.Drawing.Point(108, 81);
            this.lblCrewId.Name = "lblCrewId";
            this.lblCrewId.Size = new System.Drawing.Size(50, 13);
            this.lblCrewId.TabIndex = 0;
            this.lblCrewId.Text = "Crew Id";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(271, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 62);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Crew";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crew Members";
            // 
            // textBoxCrewId
            // 
            this.textBoxCrewId.Location = new System.Drawing.Point(211, 81);
            this.textBoxCrewId.Name = "textBoxCrewId";
            this.textBoxCrewId.Size = new System.Drawing.Size(140, 20);
            this.textBoxCrewId.TabIndex = 3;
            // 
            // textBoxCrewMembers
            // 
            this.textBoxCrewMembers.Location = new System.Drawing.Point(211, 136);
            this.textBoxCrewMembers.Name = "textBoxCrewMembers";
            this.textBoxCrewMembers.Size = new System.Drawing.Size(140, 20);
            this.textBoxCrewMembers.TabIndex = 4;
            // 
            // lblFlighhtNumber
            // 
            this.lblFlighhtNumber.AutoSize = true;
            this.lblFlighhtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlighhtNumber.Location = new System.Drawing.Point(108, 33);
            this.lblFlighhtNumber.Name = "lblFlighhtNumber";
            this.lblFlighhtNumber.Size = new System.Drawing.Size(85, 13);
            this.lblFlighhtNumber.TabIndex = 5;
            this.lblFlighhtNumber.Text = "Flight Number";
            // 
            // textBoxFlightNumber
            // 
            this.textBoxFlightNumber.Location = new System.Drawing.Point(211, 30);
            this.textBoxFlightNumber.Name = "textBoxFlightNumber";
            this.textBoxFlightNumber.Size = new System.Drawing.Size(140, 20);
            this.textBoxFlightNumber.TabIndex = 6;
            // 
            // AddCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 284);
            this.Controls.Add(this.textBoxFlightNumber);
            this.Controls.Add(this.lblFlighhtNumber);
            this.Controls.Add(this.textBoxCrewMembers);
            this.Controls.Add(this.textBoxCrewId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCrewId);
            this.Name = "AddCrew";
            this.Text = "AddCrew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCrewId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCrewId;
        private System.Windows.Forms.TextBox textBoxCrewMembers;
        private System.Windows.Forms.Label lblFlighhtNumber;
        private System.Windows.Forms.TextBox textBoxFlightNumber;
    }
}