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
            this.btnEditAppointment = new System.Windows.Forms.Button();
            this.btnRegisterPatient = new System.Windows.Forms.Button();
            this.btnExtendPerscription = new System.Windows.Forms.Button();
            this.lblReceptionist = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnFindPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.lblName.Location = new System.Drawing.Point(346, 9);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "StaffID: 0";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(12, 277);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(85, 29);
            this.btnLogOut.TabIndex = 46;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnFindPatient
            // 
            this.btnFindPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPatient.Location = new System.Drawing.Point(12, 108);
            this.btnFindPatient.Name = "btnFindPatient";
            this.btnFindPatient.Size = new System.Drawing.Size(116, 43);
            this.btnFindPatient.TabIndex = 47;
            this.btnFindPatient.Text = "Find Patient";
            this.btnFindPatient.UseVisualStyleBackColor = true;
            this.btnFindPatient.Click += new System.EventHandler(this.btnFindPatient_Click);
            // 
            // ReceptionistMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(414, 318);
            this.Controls.Add(this.btnFindPatient);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblReceptionist);
            this.Controls.Add(this.btnExtendPerscription);
            this.Controls.Add(this.btnRegisterPatient);
            this.Controls.Add(this.btnEditAppointment);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReceptionistMenu";
            this.Text = "Receptionist Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditAppointment;
        private System.Windows.Forms.Button btnRegisterPatient;
        private System.Windows.Forms.Button btnExtendPerscription;
        private System.Windows.Forms.Label lblReceptionist;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnFindPatient;
    }
}