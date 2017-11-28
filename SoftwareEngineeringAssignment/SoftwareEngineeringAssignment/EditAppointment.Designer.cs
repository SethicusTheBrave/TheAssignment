namespace SoftwareEngineeringAssignment
{
    partial class EditAppointment
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
            this.lblStaffMember = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.btnUpdateAppointment = new System.Windows.Forms.Button();
            this.txtPatientNumber = new System.Windows.Forms.TextBox();
            this.lblPatientNumber = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.calDate = new System.Windows.Forms.MonthCalendar();
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNewStaff = new System.Windows.Forms.ComboBox();
            this.txtCurrentStaff = new System.Windows.Forms.TextBox();
            this.lblNewTime = new System.Windows.Forms.Label();
            this.cbNewTime = new System.Windows.Forms.ComboBox();
            this.lblNewDate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStaffMember
            // 
            this.lblStaffMember.AutoSize = true;
            this.lblStaffMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffMember.Location = new System.Drawing.Point(58, 181);
            this.lblStaffMember.Name = "lblStaffMember";
            this.lblStaffMember.Size = new System.Drawing.Size(87, 16);
            this.lblStaffMember.TabIndex = 83;
            this.lblStaffMember.Text = "Staff Member";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(48, 248);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(110, 16);
            this.lblCurrentTime.TabIndex = 81;
            this.lblCurrentTime.Text = "Current Time Slot";
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.Location = new System.Drawing.Point(139, 507);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(92, 27);
            this.btnUpdateAppointment.TabIndex = 79;
            this.btnUpdateAppointment.Text = "Update";
            this.btnUpdateAppointment.UseVisualStyleBackColor = true;
            this.btnUpdateAppointment.Click += new System.EventHandler(this.btnUpdateAppointment_Click);
            // 
            // txtPatientNumber
            // 
            this.txtPatientNumber.Location = new System.Drawing.Point(105, 70);
            this.txtPatientNumber.Multiline = true;
            this.txtPatientNumber.Name = "txtPatientNumber";
            this.txtPatientNumber.ReadOnly = true;
            this.txtPatientNumber.Size = new System.Drawing.Size(136, 28);
            this.txtPatientNumber.TabIndex = 78;
            // 
            // lblPatientNumber
            // 
            this.lblPatientNumber.AutoSize = true;
            this.lblPatientNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientNumber.Location = new System.Drawing.Point(122, 51);
            this.lblPatientNumber.Name = "lblPatientNumber";
            this.lblPatientNumber.Size = new System.Drawing.Size(100, 16);
            this.lblPatientNumber.TabIndex = 77;
            this.lblPatientNumber.Text = "Patient Number";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(31, 131);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(136, 28);
            this.txtFirstName.TabIndex = 76;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(198, 131);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(136, 28);
            this.txtLastName.TabIndex = 75;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(233, 112);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 16);
            this.lblLastName.TabIndex = 74;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(58, 112);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 16);
            this.lblFirstName.TabIndex = 73;
            this.lblFirstName.Text = "First Name";
            // 
            // calDate
            // 
            this.calDate.Location = new System.Drawing.Point(79, 333);
            this.calDate.MaxSelectionCount = 1;
            this.calDate.Name = "calDate";
            this.calDate.TabIndex = 72;
            this.calDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calDate_DateChanged);
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.Location = new System.Drawing.Point(31, 267);
            this.txtCurrentTime.Multiline = true;
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.ReadOnly = true;
            this.txtCurrentTime.Size = new System.Drawing.Size(136, 28);
            this.txtCurrentTime.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "Staff Member";
            // 
            // cbNewStaff
            // 
            this.cbNewStaff.FormattingEnabled = true;
            this.cbNewStaff.Location = new System.Drawing.Point(198, 207);
            this.cbNewStaff.Name = "cbNewStaff";
            this.cbNewStaff.Size = new System.Drawing.Size(136, 21);
            this.cbNewStaff.TabIndex = 85;
            this.cbNewStaff.TextChanged += new System.EventHandler(this.cbNewStaff_TextChanged);
            // 
            // txtCurrentStaff
            // 
            this.txtCurrentStaff.Location = new System.Drawing.Point(31, 200);
            this.txtCurrentStaff.Multiline = true;
            this.txtCurrentStaff.Name = "txtCurrentStaff";
            this.txtCurrentStaff.ReadOnly = true;
            this.txtCurrentStaff.Size = new System.Drawing.Size(136, 28);
            this.txtCurrentStaff.TabIndex = 87;
            // 
            // lblNewTime
            // 
            this.lblNewTime.AutoSize = true;
            this.lblNewTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewTime.Location = new System.Drawing.Point(222, 248);
            this.lblNewTime.Name = "lblNewTime";
            this.lblNewTime.Size = new System.Drawing.Size(95, 16);
            this.lblNewTime.TabIndex = 89;
            this.lblNewTime.Text = "New Time Slot";
            // 
            // cbNewTime
            // 
            this.cbNewTime.FormattingEnabled = true;
            this.cbNewTime.Location = new System.Drawing.Point(198, 267);
            this.cbNewTime.Name = "cbNewTime";
            this.cbNewTime.Size = new System.Drawing.Size(136, 21);
            this.cbNewTime.TabIndex = 88;
            // 
            // lblNewDate
            // 
            this.lblNewDate.AutoSize = true;
            this.lblNewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewDate.Location = new System.Drawing.Point(155, 308);
            this.lblNewDate.Name = "lblNewDate";
            this.lblNewDate.Size = new System.Drawing.Size(67, 16);
            this.lblNewDate.TabIndex = 90;
            this.lblNewDate.Text = "New Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 91;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(299, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 15);
            this.lblName.TabIndex = 93;
            this.lblName.Text = "StaffID: 0";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDoctor.Location = new System.Drawing.Point(9, 9);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(75, 15);
            this.lblDoctor.TabIndex = 92;
            this.lblDoctor.Text = "Receptionist";
            // 
            // EditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(367, 592);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNewDate);
            this.Controls.Add(this.lblNewTime);
            this.Controls.Add(this.cbNewTime);
            this.Controls.Add(this.txtCurrentStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNewStaff);
            this.Controls.Add(this.txtCurrentTime);
            this.Controls.Add(this.lblStaffMember);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.btnUpdateAppointment);
            this.Controls.Add(this.txtPatientNumber);
            this.Controls.Add(this.lblPatientNumber);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.calDate);
            this.Name = "EditAppointment";
            this.Text = "EditAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaffMember;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Button btnUpdateAppointment;
        private System.Windows.Forms.TextBox txtPatientNumber;
        private System.Windows.Forms.Label lblPatientNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.MonthCalendar calDate;
        private System.Windows.Forms.TextBox txtCurrentTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNewStaff;
        private System.Windows.Forms.TextBox txtCurrentStaff;
        private System.Windows.Forms.Label lblNewTime;
        private System.Windows.Forms.ComboBox cbNewTime;
        private System.Windows.Forms.Label lblNewDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDoctor;
    }
}