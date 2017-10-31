namespace SoftwareEngineeringAssignment
{
    partial class ManagerMenu
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
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnEditStaffSchedule = new System.Windows.Forms.Button();
            this.btnViewStaffSchedule = new System.Windows.Forms.Button();
            this.btnViewCurrentStaff = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Location = new System.Drawing.Point(286, 215);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(116, 43);
            this.btnAddStaff.TabIndex = 15;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnEditStaffSchedule
            // 
            this.btnEditStaffSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStaffSchedule.Location = new System.Drawing.Point(12, 215);
            this.btnEditStaffSchedule.Name = "btnEditStaffSchedule";
            this.btnEditStaffSchedule.Size = new System.Drawing.Size(116, 43);
            this.btnEditStaffSchedule.TabIndex = 14;
            this.btnEditStaffSchedule.Text = "Edit Staff Schedule";
            this.btnEditStaffSchedule.UseVisualStyleBackColor = true;
            this.btnEditStaffSchedule.Click += new System.EventHandler(this.btnEditStaffSchedule_Click);
            // 
            // btnViewStaffSchedule
            // 
            this.btnViewStaffSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStaffSchedule.Location = new System.Drawing.Point(286, 108);
            this.btnViewStaffSchedule.Name = "btnViewStaffSchedule";
            this.btnViewStaffSchedule.Size = new System.Drawing.Size(116, 43);
            this.btnViewStaffSchedule.TabIndex = 13;
            this.btnViewStaffSchedule.Text = "View Staff Schedule";
            this.btnViewStaffSchedule.UseVisualStyleBackColor = true;
            this.btnViewStaffSchedule.Click += new System.EventHandler(this.btnViewStaffSchedule_Click);
            // 
            // btnViewCurrentStaff
            // 
            this.btnViewCurrentStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCurrentStaff.Location = new System.Drawing.Point(12, 108);
            this.btnViewCurrentStaff.Name = "btnViewCurrentStaff";
            this.btnViewCurrentStaff.Size = new System.Drawing.Size(116, 43);
            this.btnViewCurrentStaff.TabIndex = 12;
            this.btnViewCurrentStaff.Text = "View Current Staff";
            this.btnViewCurrentStaff.UseVisualStyleBackColor = true;
            this.btnViewCurrentStaff.Click += new System.EventHandler(this.btnViewCurrentStaff_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(283, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 15);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Logged In: Name";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblManager.Location = new System.Drawing.Point(9, 9);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(57, 15);
            this.lblManager.TabIndex = 16;
            this.lblManager.Text = "Manager";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 29);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(317, 274);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(85, 29);
            this.btnLogOut.TabIndex = 46;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(414, 315);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.btnEditStaffSchedule);
            this.Controls.Add(this.btnViewStaffSchedule);
            this.Controls.Add(this.btnViewCurrentStaff);
            this.Name = "ManagerMenu";
            this.Text = "ManagerMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnEditStaffSchedule;
        private System.Windows.Forms.Button btnViewStaffSchedule;
        private System.Windows.Forms.Button btnViewCurrentStaff;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogOut;
    }
}