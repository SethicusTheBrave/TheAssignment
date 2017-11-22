namespace SoftwareEngineeringAssignment
{
    partial class ExtendPrescription
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
            this.lblStaffType = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDrugID = new System.Windows.Forms.TextBox();
            this.btnExtend = new System.Windows.Forms.Button();
            this.lblDrugID = new System.Windows.Forms.Label();
            this.lvDrugs = new System.Windows.Forms.ListView();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbWeeks = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(498, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 15);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "StaffID: 0";
            // 
            // lblStaffType
            // 
            this.lblStaffType.AutoSize = true;
            this.lblStaffType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStaffType.Location = new System.Drawing.Point(15, 9);
            this.lblStaffType.Name = "lblStaffType";
            this.lblStaffType.Size = new System.Drawing.Size(57, 15);
            this.lblStaffType.TabIndex = 22;
            this.lblStaffType.Text = "StaffType";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(542, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 29);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(542, 216);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 29);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtDrugID
            // 
            this.txtDrugID.Location = new System.Drawing.Point(505, 52);
            this.txtDrugID.Name = "txtDrugID";
            this.txtDrugID.Size = new System.Drawing.Size(122, 20);
            this.txtDrugID.TabIndex = 27;
            // 
            // btnExtend
            // 
            this.btnExtend.Location = new System.Drawing.Point(542, 124);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(85, 35);
            this.btnExtend.TabIndex = 28;
            this.btnExtend.Text = "Extend Presecription";
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // lblDrugID
            // 
            this.lblDrugID.AutoSize = true;
            this.lblDrugID.Location = new System.Drawing.Point(409, 59);
            this.lblDrugID.Name = "lblDrugID";
            this.lblDrugID.Size = new System.Drawing.Size(44, 13);
            this.lblDrugID.TabIndex = 29;
            this.lblDrugID.Text = "Drug ID";
            // 
            // lvDrugs
            // 
            this.lvDrugs.Location = new System.Drawing.Point(3, 52);
            this.lvDrugs.Name = "lvDrugs";
            this.lvDrugs.Size = new System.Drawing.Size(400, 193);
            this.lvDrugs.TabIndex = 30;
            this.lvDrugs.UseCompatibleStateImageBehavior = false;
            this.lvDrugs.View = System.Windows.Forms.View.Details;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(409, 86);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(90, 13);
            this.lblTime.TabIndex = 31;
            this.lblTime.Text = "Extention Desired";
            // 
            // cbWeeks
            // 
            this.cbWeeks.FormattingEnabled = true;
            this.cbWeeks.Location = new System.Drawing.Point(505, 86);
            this.cbWeeks.Name = "cbWeeks";
            this.cbWeeks.Size = new System.Drawing.Size(122, 21);
            this.cbWeeks.TabIndex = 32;
            // 
            // ExtendPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(639, 257);
            this.Controls.Add(this.cbWeeks);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lvDrugs);
            this.Controls.Add(this.lblDrugID);
            this.Controls.Add(this.btnExtend);
            this.Controls.Add(this.txtDrugID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStaffType);
            this.Name = "ExtendPrescription";
            this.Text = "ExtendPrescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStaffType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtDrugID;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Label lblDrugID;
        private System.Windows.Forms.ListView lvDrugs;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cbWeeks;
    }
}