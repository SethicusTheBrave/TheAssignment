﻿namespace SoftwareEngineeringAssignment
{
    partial class PatientMenu
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
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dgNotes = new System.Windows.Forms.DataGridView();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblPrescriptions = new System.Windows.Forms.Label();
            this.dgPrescriptions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrescriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTests = new System.Windows.Forms.Label();
            this.dgTests = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmResults = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrescriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTests)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(486, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 15);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Logged In: Name";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDoctor.Location = new System.Drawing.Point(12, 9);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(43, 15);
            this.lblDoctor.TabIndex = 20;
            this.lblDoctor.Text = "Doctor";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(197, 68);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 16);
            this.lblLastName.TabIndex = 38;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(39, 68);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 16);
            this.lblFirstName.TabIndex = 37;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 87);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(136, 28);
            this.txtFirstName.TabIndex = 43;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(173, 87);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(136, 28);
            this.txtLastName.TabIndex = 42;
            // 
            // dgNotes
            // 
            this.dgNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDate,
            this.clmNotes});
            this.dgNotes.Location = new System.Drawing.Point(12, 197);
            this.dgNotes.Name = "dgNotes";
            this.dgNotes.Size = new System.Drawing.Size(243, 76);
            this.dgNotes.TabIndex = 44;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Date";
            this.clmDate.Name = "clmDate";
            // 
            // clmNotes
            // 
            this.clmNotes.HeaderText = "Notes";
            this.clmNotes.Name = "clmNotes";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(96, 178);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(44, 16);
            this.lblNotes.TabIndex = 45;
            this.lblNotes.Text = "Notes";
            // 
            // lblPrescriptions
            // 
            this.lblPrescriptions.AutoSize = true;
            this.lblPrescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescriptions.Location = new System.Drawing.Point(99, 291);
            this.lblPrescriptions.Name = "lblPrescriptions";
            this.lblPrescriptions.Size = new System.Drawing.Size(86, 16);
            this.lblPrescriptions.TabIndex = 47;
            this.lblPrescriptions.Text = "Prescriptions";
            // 
            // dgPrescriptions
            // 
            this.dgPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrescriptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clmPrescriptions,
            this.dataGridViewTextBoxColumn2});
            this.dgPrescriptions.Location = new System.Drawing.Point(15, 310);
            this.dgPrescriptions.Name = "dgPrescriptions";
            this.dgPrescriptions.Size = new System.Drawing.Size(345, 76);
            this.dgPrescriptions.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // clmPrescriptions
            // 
            this.clmPrescriptions.HeaderText = "Prescription";
            this.clmPrescriptions.Name = "clmPrescriptions";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // lblTests
            // 
            this.lblTests.AutoSize = true;
            this.lblTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTests.Location = new System.Drawing.Point(106, 394);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(42, 16);
            this.lblTests.TabIndex = 49;
            this.lblTests.Text = "Tests";
            // 
            // dgTests
            // 
            this.dgTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.clmTest,
            this.clmResults,
            this.dataGridViewTextBoxColumn4});
            this.dgTests.Location = new System.Drawing.Point(15, 413);
            this.dgTests.Name = "dgTests";
            this.dgTests.Size = new System.Drawing.Size(446, 76);
            this.dgTests.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // clmTest
            // 
            this.clmTest.HeaderText = "Test";
            this.clmTest.Name = "clmTest";
            // 
            // clmResults
            // 
            this.clmResults.HeaderText = "Result";
            this.clmResults.Name = "clmResults";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(499, 542);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 29);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(499, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 29);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Location = new System.Drawing.Point(499, 69);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(85, 55);
            this.btnBookAppointment.TabIndex = 52;
            this.btnBookAppointment.Text = "Book Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(287, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 53;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(376, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 29);
            this.button2.TabIndex = 54;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(499, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 29);
            this.button3.TabIndex = 55;
            this.button3.Text = "New";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(596, 579);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBookAppointment);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTests);
            this.Controls.Add(this.dgTests);
            this.Controls.Add(this.lblPrescriptions);
            this.Controls.Add(this.dgPrescriptions);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.dgNotes);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDoctor);
            this.Name = "Patient";
            this.Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)(this.dgNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrescriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DataGridView dgNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblPrescriptions;
        private System.Windows.Forms.DataGridView dgPrescriptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrescriptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblTests;
        private System.Windows.Forms.DataGridView dgTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}