namespace SoftwareEngineeringAssignment
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
            this.btnNewNote = new System.Windows.Forms.Button();
            this.btnNewPrescription = new System.Windows.Forms.Button();
            this.btnNewTest = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtPatientNumber = new System.Windows.Forms.TextBox();
            this.lblPatientNumber = new System.Windows.Forms.Label();
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
            this.lblName.Location = new System.Drawing.Point(704, 11);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 18);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "StaffID: 0";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDoctor.Location = new System.Drawing.Point(16, 11);
            this.lblDoctor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(54, 18);
            this.lblDoctor.TabIndex = 20;
            this.lblDoctor.Text = "Doctor";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(259, 133);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(91, 20);
            this.lblLastName.TabIndex = 38;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(48, 133);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(92, 20);
            this.lblFirstName.TabIndex = 37;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 156);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(180, 34);
            this.txtFirstName.TabIndex = 43;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(227, 156);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(180, 34);
            this.txtLastName.TabIndex = 42;
            // 
            // dgNotes
            // 
            this.dgNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDate,
            this.clmNotes});
            this.dgNotes.Location = new System.Drawing.Point(16, 242);
            this.dgNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgNotes.Name = "dgNotes";
            this.dgNotes.Size = new System.Drawing.Size(324, 94);
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
            this.lblNotes.Location = new System.Drawing.Point(128, 219);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(53, 20);
            this.lblNotes.TabIndex = 45;
            this.lblNotes.Text = "Notes";
            // 
            // lblPrescriptions
            // 
            this.lblPrescriptions.AutoSize = true;
            this.lblPrescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescriptions.Location = new System.Drawing.Point(132, 358);
            this.lblPrescriptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrescriptions.Name = "lblPrescriptions";
            this.lblPrescriptions.Size = new System.Drawing.Size(108, 20);
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
            this.dgPrescriptions.Location = new System.Drawing.Point(20, 382);
            this.dgPrescriptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgPrescriptions.Name = "dgPrescriptions";
            this.dgPrescriptions.Size = new System.Drawing.Size(460, 94);
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
            this.lblTests.Location = new System.Drawing.Point(141, 485);
            this.lblTests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(51, 20);
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
            this.dgTests.Location = new System.Drawing.Point(20, 508);
            this.dgTests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgTests.Name = "dgTests";
            this.dgTests.Size = new System.Drawing.Size(595, 94);
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
            this.btnExit.Location = new System.Drawing.Point(665, 667);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 36);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(665, 624);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 36);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Location = new System.Drawing.Point(665, 85);
            this.btnBookAppointment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(113, 68);
            this.btnBookAppointment.TabIndex = 52;
            this.btnBookAppointment.Text = "Book Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            // 
            // btnNewNote
            // 
            this.btnNewNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNote.Location = new System.Drawing.Point(383, 300);
            this.btnNewNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(113, 36);
            this.btnNewNote.TabIndex = 53;
            this.btnNewNote.Text = "New";
            this.btnNewNote.UseVisualStyleBackColor = true;
            // 
            // btnNewPrescription
            // 
            this.btnNewPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPrescription.Location = new System.Drawing.Point(501, 439);
            this.btnNewPrescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewPrescription.Name = "btnNewPrescription";
            this.btnNewPrescription.Size = new System.Drawing.Size(113, 36);
            this.btnNewPrescription.TabIndex = 54;
            this.btnNewPrescription.Text = "New";
            this.btnNewPrescription.UseVisualStyleBackColor = true;
            // 
            // btnNewTest
            // 
            this.btnNewTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTest.Location = new System.Drawing.Point(665, 555);
            this.btnNewTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewTest.Name = "btnNewTest";
            this.btnNewTest.Size = new System.Drawing.Size(113, 36);
            this.btnNewTest.TabIndex = 55;
            this.btnNewTest.Text = "New";
            this.btnNewTest.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(544, 667);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(113, 36);
            this.btnNext.TabIndex = 56;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtPatientNumber
            // 
            this.txtPatientNumber.Location = new System.Drawing.Point(12, 85);
            this.txtPatientNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatientNumber.Multiline = true;
            this.txtPatientNumber.Name = "txtPatientNumber";
            this.txtPatientNumber.ReadOnly = true;
            this.txtPatientNumber.Size = new System.Drawing.Size(180, 34);
            this.txtPatientNumber.TabIndex = 58;
            // 
            // lblPatientNumber
            // 
            this.lblPatientNumber.AutoSize = true;
            this.lblPatientNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientNumber.Location = new System.Drawing.Point(35, 62);
            this.lblPatientNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientNumber.Name = "lblPatientNumber";
            this.lblPatientNumber.Size = new System.Drawing.Size(125, 20);
            this.lblPatientNumber.TabIndex = 57;
            this.lblPatientNumber.Text = "Patient Number";
            // 
            // PatientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(798, 555);
            this.Controls.Add(this.txtPatientNumber);
            this.Controls.Add(this.lblPatientNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnNewTest);
            this.Controls.Add(this.btnNewPrescription);
            this.Controls.Add(this.btnNewNote);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PatientMenu";
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
        private System.Windows.Forms.Button btnNewNote;
        private System.Windows.Forms.Button btnNewPrescription;
        private System.Windows.Forms.Button btnNewTest;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtPatientNumber;
        private System.Windows.Forms.Label lblPatientNumber;
    }
}