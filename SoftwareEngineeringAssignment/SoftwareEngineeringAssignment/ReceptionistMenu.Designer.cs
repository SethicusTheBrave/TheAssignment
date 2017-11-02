namespace SoftwareEngineeringAssignment
{
    partial class ReceptionistMenu
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
            this.btnCreateAppointment = new System.Windows.Forms.Button();
            this.btnEditAppointment = new System.Windows.Forms.Button();
            this.btnRegisterPatient = new System.Windows.Forms.Button();
            this.btnExtendPerscription = new System.Windows.Forms.Button();
            this.lblReceptionist = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateAppointment
            // 
            this.btnCreateAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAppointment.Location = new System.Drawing.Point(12, 108);
            this.btnCreateAppointment.Name = "btnCreateAppointment";
            this.btnCreateAppointment.Size = new System.Drawing.Size(116, 43);
            this.btnCreateAppointment.TabIndex = 0;
            this.btnCreateAppointment.Text = "Book Appointment";
            this.btnCreateAppointment.UseVisualStyleBackColor = true;
            this.btnCreateAppointment.Click += new System.EventHandler(this.btnCreateAppointment_Click);
            // 
            // btnEditAppointment
            // 
            this.btnEditAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAppointment.Location = new System.Drawing.Point(286, 108);
            this.btnEditAppointment.Name = "btnEditAppointment";
            this.btnEditAppointment.Size = new System.Drawing.Size(116, 43);
            this.btnEditAppointment.TabIndex = 1;
            this.btnEditAppointment.Text = "Edit Appointment";
            this.btnEditAppointment.UseVisualStyleBackColor = true;
            this.btnEditAppointment.Click += new System.EventHandler(this.btnEditAppointment_Click);
            // 
            // btnRegisterPatient
            // 
            this.btnRegisterPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterPatient.Location = new System.Drawing.Point(12, 215);
            this.btnRegisterPatient.Name = "btnRegisterPatient";
            this.btnRegisterPatient.Size = new System.Drawing.Size(116, 43);
            this.btnRegisterPatient.TabIndex = 2;
            this.btnRegisterPatient.Text = "Register Patient";
            this.btnRegisterPatient.UseVisualStyleBackColor = true;
            this.btnRegisterPatient.Click += new System.EventHandler(this.btnRegisterPatient_Click);
            // 
            // btnExtendPerscription
            // 
            this.btnExtendPerscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtendPerscription.Location = new System.Drawing.Point(286, 215);
            this.btnExtendPerscription.Name = "btnExtendPerscription";
            this.btnExtendPerscription.Size = new System.Drawing.Size(116, 43);
            this.btnExtendPerscription.TabIndex = 3;
            this.btnExtendPerscription.Text = "Extend Perscription";
            this.btnExtendPerscription.UseVisualStyleBackColor = true;
            this.btnExtendPerscription.Click += new System.EventHandler(this.btnExtendPerscription_Click);
            // 
            // lblReceptionist
            // 
            this.lblReceptionist.AutoSize = true;
            this.lblReceptionist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReceptionist.Location = new System.Drawing.Point(9, 9);
            this.lblReceptionist.Name = "lblReceptionist";
            this.lblReceptionist.Size = new System.Drawing.Size(75, 15);
            this.lblReceptionist.TabIndex = 4;
            this.lblReceptionist.Text = "Receptionist";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(283, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Logged In: Name";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 277);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 29);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(317, 277);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(85, 29);
            this.btnLogOut.TabIndex = 46;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(414, 318);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblReceptionist);
            this.Controls.Add(this.btnExtendPerscription);
            this.Controls.Add(this.btnRegisterPatient);
            this.Controls.Add(this.btnEditAppointment);
            this.Controls.Add(this.btnCreateAppointment);
            this.Name = "Main_Menu";
            this.Text = "Receptionist Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAppointment;
        private System.Windows.Forms.Button btnEditAppointment;
        private System.Windows.Forms.Button btnRegisterPatient;
        private System.Windows.Forms.Button btnExtendPerscription;
        private System.Windows.Forms.Label lblReceptionist;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogOut;
    }
}