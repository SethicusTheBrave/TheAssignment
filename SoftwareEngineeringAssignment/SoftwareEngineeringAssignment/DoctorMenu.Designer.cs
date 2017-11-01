namespace SoftwareEngineeringAssignment
{
    partial class DoctorMenu
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.btnTodoList = new System.Windows.Forms.Button();
            this.btnConsoltation = new System.Windows.Forms.Button();
            this.btnPatientSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(283, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 15);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Logged In: Name";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDoctor.Location = new System.Drawing.Point(9, 9);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(43, 15);
            this.lblDoctor.TabIndex = 18;
            this.lblDoctor.Text = "Doctor";
            // 
            // btnTodoList
            // 
            this.btnTodoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodoList.Location = new System.Drawing.Point(12, 215);
            this.btnTodoList.Name = "btnTodoList";
            this.btnTodoList.Size = new System.Drawing.Size(116, 43);
            this.btnTodoList.TabIndex = 22;
            this.btnTodoList.Text = "Todo List";
            this.btnTodoList.UseVisualStyleBackColor = true;
            // 
            // btnConsoltation
            // 
            this.btnConsoltation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsoltation.Location = new System.Drawing.Point(286, 108);
            this.btnConsoltation.Name = "btnConsoltation";
            this.btnConsoltation.Size = new System.Drawing.Size(116, 43);
            this.btnConsoltation.TabIndex = 21;
            this.btnConsoltation.Text = "Consoltation";
            this.btnConsoltation.UseVisualStyleBackColor = true;
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSearch.Location = new System.Drawing.Point(12, 108);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(116, 43);
            this.btnPatientSearch.TabIndex = 20;
            this.btnPatientSearch.Text = "Patient Search";
            this.btnPatientSearch.UseVisualStyleBackColor = true;
            this.btnPatientSearch.Click += new System.EventHandler(this.btnPatientSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 29);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(317, 280);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(85, 29);
            this.btnLogOut.TabIndex = 45;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // DoctorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(414, 321);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTodoList);
            this.Controls.Add(this.btnConsoltation);
            this.Controls.Add(this.btnPatientSearch);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDoctor);
            this.Name = "DoctorMenu";
            this.Text = "DoctorMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Button btnTodoList;
        private System.Windows.Forms.Button btnConsoltation;
        private System.Windows.Forms.Button btnPatientSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogOut;
    }
}