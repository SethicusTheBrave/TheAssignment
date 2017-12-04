namespace SoftwareEngineeringAssignment
{
    partial class StaffSchedule
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.LstStaffSchedule = new System.Windows.Forms.ListView();
            this.clmStaffID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMonday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTuesday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmWednesday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cllmThursday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFriday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSaturday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSunday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(876, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 29);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(906, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 15);
            this.lblName.TabIndex = 53;
            this.lblName.Text = "StaffID: 0";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblManager.Location = new System.Drawing.Point(7, 9);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(57, 15);
            this.lblManager.TabIndex = 52;
            this.lblManager.Text = "Manager";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 29);
            this.btnExit.TabIndex = 54;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // LstStaffSchedule
            // 
            this.LstStaffSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmStaffID,
            this.clmFirstName,
            this.clmLastName,
            this.clmMonday,
            this.clmTuesday,
            this.clmWednesday,
            this.cllmThursday,
            this.clmFriday,
            this.clmSaturday,
            this.clmSunday});
            this.LstStaffSchedule.Location = new System.Drawing.Point(10, 28);
            this.LstStaffSchedule.Name = "LstStaffSchedule";
            this.LstStaffSchedule.Size = new System.Drawing.Size(951, 335);
            this.LstStaffSchedule.TabIndex = 55;
            this.LstStaffSchedule.UseCompatibleStateImageBehavior = false;
            // 
            // clmStaffID
            // 
            this.clmStaffID.Text = "Staff ID";
            // 
            // clmFirstName
            // 
            this.clmFirstName.Text = "First Name";
            // 
            // clmLastName
            // 
            this.clmLastName.Text = "Last Name";
            // 
            // clmMonday
            // 
            this.clmMonday.Text = "Monday";
            // 
            // clmTuesday
            // 
            this.clmTuesday.Text = "Tuesday";
            // 
            // clmWednesday
            // 
            this.clmWednesday.Text = "Wednesday";
            // 
            // cllmThursday
            // 
            this.cllmThursday.Text = "Thursday";
            // 
            // clmFriday
            // 
            this.clmFriday.Text = "Friday";
            // 
            // clmSaturday
            // 
            this.clmSaturday.Text = "Saturday";
            // 
            // clmSunday
            // 
            this.clmSunday.Text = "Sundqay";
            // 
            // StaffSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(974, 410);
            this.Controls.Add(this.LstStaffSchedule);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.btnSave);
            this.Name = "StaffSchedule";
            this.Text = "StaffSchedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView LstStaffSchedule;
        private System.Windows.Forms.ColumnHeader clmStaffID;
        private System.Windows.Forms.ColumnHeader clmFirstName;
        private System.Windows.Forms.ColumnHeader clmLastName;
        private System.Windows.Forms.ColumnHeader clmMonday;
        private System.Windows.Forms.ColumnHeader clmTuesday;
        private System.Windows.Forms.ColumnHeader clmWednesday;
        private System.Windows.Forms.ColumnHeader cllmThursday;
        private System.Windows.Forms.ColumnHeader clmFriday;
        private System.Windows.Forms.ColumnHeader clmSaturday;
        private System.Windows.Forms.ColumnHeader clmSunday;
    }
}