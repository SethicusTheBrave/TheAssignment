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
            this.dgSchedule = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.clmFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStaffType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSaturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSchedule
            // 
            this.dgSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFullName,
            this.clmStaffType,
            this.clmMonday,
            this.clmTuesday,
            this.clmWednesday,
            this.clmThursday,
            this.clmFriday,
            this.clmSaturday,
            this.clmSunday});
            this.dgSchedule.Location = new System.Drawing.Point(11, 73);
            this.dgSchedule.Name = "dgSchedule";
            this.dgSchedule.Size = new System.Drawing.Size(950, 280);
            this.dgSchedule.TabIndex = 0;
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
            this.lblName.Location = new System.Drawing.Point(859, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 15);
            this.lblName.TabIndex = 53;
            this.lblName.Text = "Logged In: Name";
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
            // clmFullName
            // 
            this.clmFullName.HeaderText = "Full_Name";
            this.clmFullName.Name = "clmFullName";
            // 
            // clmStaffType
            // 
            this.clmStaffType.HeaderText = "StaffType";
            this.clmStaffType.Name = "clmStaffType";
            // 
            // clmMonday
            // 
            this.clmMonday.HeaderText = "Monday";
            this.clmMonday.Name = "clmMonday";
            // 
            // clmTuesday
            // 
            this.clmTuesday.HeaderText = "Tuesday";
            this.clmTuesday.Name = "clmTuesday";
            // 
            // clmWednesday
            // 
            this.clmWednesday.HeaderText = "Wednesday";
            this.clmWednesday.Name = "clmWednesday";
            // 
            // clmThursday
            // 
            this.clmThursday.HeaderText = "Thursday";
            this.clmThursday.Name = "clmThursday";
            // 
            // clmFriday
            // 
            this.clmFriday.HeaderText = "Friday";
            this.clmFriday.Name = "clmFriday";
            // 
            // clmSaturday
            // 
            this.clmSaturday.HeaderText = "Saturday";
            this.clmSaturday.Name = "clmSaturday";
            // 
            // clmSunday
            // 
            this.clmSunday.HeaderText = "Sunday";
            this.clmSunday.Name = "clmSunday";
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
            // StaffSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(974, 410);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgSchedule);
            this.Name = "StaffSchedule";
            this.Text = "StaffSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSchedule;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStaffType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFriday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSaturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSunday;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Button btnExit;
    }
}