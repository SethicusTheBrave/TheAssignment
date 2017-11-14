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
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblPrescriptions = new System.Windows.Forms.Label();
            this.lblTests = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBookAppointment = new System.Windows.Forms.Button();
            this.btnNewNote = new System.Windows.Forms.Button();
            this.btnNewPrescription = new System.Windows.Forms.Button();
            this.btnNewTest = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtPatientNumber = new System.Windows.Forms.TextBox();
            this.lblPatientNumber = new System.Windows.Forms.Label();
            this.btnPresent = new System.Windows.Forms.Button();
            this.txtMedicalHistory = new System.Windows.Forms.TextBox();
            this.lblMedicalHistory = new System.Windows.Forms.Label();
            this.lvPrescriptions = new System.Windows.Forms.ListView();
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMedicine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvNotes = new System.Windows.Forms.ListView();
            this.clmDate2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTests = new System.Windows.Forms.ListView();
            this.clmDate3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTest2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNotes2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(1836, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 15);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "StaffID: 0";
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
            this.lblLastName.Location = new System.Drawing.Point(194, 108);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 16);
            this.lblLastName.TabIndex = 38;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(36, 108);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 16);
            this.lblFirstName.TabIndex = 37;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(9, 127);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(136, 28);
            this.txtFirstName.TabIndex = 43;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(170, 127);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(136, 28);
            this.txtLastName.TabIndex = 42;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(1567, 31);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(44, 16);
            this.lblNotes.TabIndex = 45;
            this.lblNotes.Text = "Notes";
            // 
            // lblPrescriptions
            // 
            this.lblPrescriptions.AutoSize = true;
            this.lblPrescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescriptions.Location = new System.Drawing.Point(456, 31);
            this.lblPrescriptions.Name = "lblPrescriptions";
            this.lblPrescriptions.Size = new System.Drawing.Size(86, 16);
            this.lblPrescriptions.TabIndex = 47;
            this.lblPrescriptions.Text = "Prescriptions";
            // 
            // lblTests
            // 
            this.lblTests.AutoSize = true;
            this.lblTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTests.Location = new System.Drawing.Point(1053, 31);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(42, 16);
            this.lblTests.TabIndex = 49;
            this.lblTests.Text = "Tests";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(9, 973);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 29);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBookAppointment
            // 
            this.btnBookAppointment.Location = new System.Drawing.Point(1807, 42);
            this.btnBookAppointment.Name = "btnBookAppointment";
            this.btnBookAppointment.Size = new System.Drawing.Size(85, 55);
            this.btnBookAppointment.TabIndex = 52;
            this.btnBookAppointment.Text = "Book Appointment";
            this.btnBookAppointment.UseVisualStyleBackColor = true;
            this.btnBookAppointment.Click += new System.EventHandler(this.btnBookAppointment_Click);
            // 
            // btnNewNote
            // 
            this.btnNewNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNote.Location = new System.Drawing.Point(1624, 20);
            this.btnNewNote.Name = "btnNewNote";
            this.btnNewNote.Size = new System.Drawing.Size(85, 29);
            this.btnNewNote.TabIndex = 53;
            this.btnNewNote.Text = "New";
            this.btnNewNote.UseVisualStyleBackColor = true;
            this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
            // 
            // btnNewPrescription
            // 
            this.btnNewPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPrescription.Location = new System.Drawing.Point(557, 19);
            this.btnNewPrescription.Name = "btnNewPrescription";
            this.btnNewPrescription.Size = new System.Drawing.Size(85, 29);
            this.btnNewPrescription.TabIndex = 54;
            this.btnNewPrescription.Text = "New";
            this.btnNewPrescription.UseVisualStyleBackColor = true;
            this.btnNewPrescription.Click += new System.EventHandler(this.btnNewPrescription_Click);
            // 
            // btnNewTest
            // 
            this.btnNewTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTest.Location = new System.Drawing.Point(1101, 20);
            this.btnNewTest.Name = "btnNewTest";
            this.btnNewTest.Size = new System.Drawing.Size(85, 29);
            this.btnNewTest.TabIndex = 55;
            this.btnNewTest.Text = "New";
            this.btnNewTest.UseVisualStyleBackColor = true;
            this.btnNewTest.Click += new System.EventHandler(this.btnNewTest_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1807, 1000);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 29);
            this.btnNext.TabIndex = 56;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtPatientNumber
            // 
            this.txtPatientNumber.Location = new System.Drawing.Point(9, 69);
            this.txtPatientNumber.Multiline = true;
            this.txtPatientNumber.Name = "txtPatientNumber";
            this.txtPatientNumber.ReadOnly = true;
            this.txtPatientNumber.Size = new System.Drawing.Size(136, 28);
            this.txtPatientNumber.TabIndex = 58;
            // 
            // lblPatientNumber
            // 
            this.lblPatientNumber.AutoSize = true;
            this.lblPatientNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientNumber.Location = new System.Drawing.Point(26, 50);
            this.lblPatientNumber.Name = "lblPatientNumber";
            this.lblPatientNumber.Size = new System.Drawing.Size(100, 16);
            this.lblPatientNumber.TabIndex = 57;
            this.lblPatientNumber.Text = "Patient Number";
            // 
            // btnPresent
            // 
            this.btnPresent.Location = new System.Drawing.Point(1807, 102);
            this.btnPresent.Margin = new System.Windows.Forms.Padding(2);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(85, 20);
            this.btnPresent.TabIndex = 59;
            this.btnPresent.Text = "Present";
            this.btnPresent.UseVisualStyleBackColor = true;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // txtMedicalHistory
            // 
            this.txtMedicalHistory.Location = new System.Drawing.Point(9, 231);
            this.txtMedicalHistory.Multiline = true;
            this.txtMedicalHistory.Name = "txtMedicalHistory";
            this.txtMedicalHistory.ReadOnly = true;
            this.txtMedicalHistory.Size = new System.Drawing.Size(297, 167);
            this.txtMedicalHistory.TabIndex = 60;
            // 
            // lblMedicalHistory
            // 
            this.lblMedicalHistory.AutoSize = true;
            this.lblMedicalHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicalHistory.Location = new System.Drawing.Point(95, 212);
            this.lblMedicalHistory.Name = "lblMedicalHistory";
            this.lblMedicalHistory.Size = new System.Drawing.Size(101, 16);
            this.lblMedicalHistory.TabIndex = 61;
            this.lblMedicalHistory.Text = "Medical History";
            // 
            // lvPrescriptions
            // 
            this.lvPrescriptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDate,
            this.clmMedicine});
            this.lvPrescriptions.Location = new System.Drawing.Point(387, 58);
            this.lvPrescriptions.Name = "lvPrescriptions";
            this.lvPrescriptions.Size = new System.Drawing.Size(392, 393);
            this.lvPrescriptions.TabIndex = 62;
            this.lvPrescriptions.UseCompatibleStateImageBehavior = false;
            this.lvPrescriptions.View = System.Windows.Forms.View.Details;
            // 
            // clmDate
            // 
            this.clmDate.Text = "Date";
            // 
            // clmMedicine
            // 
            this.clmMedicine.Text = "Medicine";
            // 
            // lvNotes
            // 
            this.lvNotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDate2,
            this.clmNote});
            this.lvNotes.Location = new System.Drawing.Point(1372, 55);
            this.lvNotes.Name = "lvNotes";
            this.lvNotes.Size = new System.Drawing.Size(409, 393);
            this.lvNotes.TabIndex = 63;
            this.lvNotes.UseCompatibleStateImageBehavior = false;
            this.lvNotes.View = System.Windows.Forms.View.Details;
            // 
            // clmDate2
            // 
            this.clmDate2.Text = "Date";
            // 
            // clmNote
            // 
            this.clmNote.Text = "Note";
            // 
            // lvTests
            // 
            this.lvTests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDate3,
            this.clmTest2,
            this.clmResult,
            this.clmNotes2});
            this.lvTests.Location = new System.Drawing.Point(843, 58);
            this.lvTests.Name = "lvTests";
            this.lvTests.Size = new System.Drawing.Size(446, 390);
            this.lvTests.TabIndex = 64;
            this.lvTests.UseCompatibleStateImageBehavior = false;
            this.lvTests.View = System.Windows.Forms.View.Details;
            // 
            // clmDate3
            // 
            this.clmDate3.Text = "Date";
            // 
            // clmTest2
            // 
            this.clmTest2.Text = "Test";
            // 
            // clmResult
            // 
            this.clmResult.Text = "Result";
            // 
            // clmNotes2
            // 
            this.clmNotes2.Text = "Notes";
            // 
            // PatientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lvTests);
            this.Controls.Add(this.lvNotes);
            this.Controls.Add(this.lvPrescriptions);
            this.Controls.Add(this.lblMedicalHistory);
            this.Controls.Add(this.txtMedicalHistory);
            this.Controls.Add(this.btnPresent);
            this.Controls.Add(this.txtPatientNumber);
            this.Controls.Add(this.lblPatientNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnNewTest);
            this.Controls.Add(this.btnNewPrescription);
            this.Controls.Add(this.btnNewNote);
            this.Controls.Add(this.btnBookAppointment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTests);
            this.Controls.Add(this.lblPrescriptions);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDoctor);
            this.Name = "PatientMenu";
            this.Text = "Patient";
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
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblPrescriptions;
        private System.Windows.Forms.Label lblTests;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnNewNote;
        private System.Windows.Forms.Button btnNewPrescription;
        private System.Windows.Forms.Button btnNewTest;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtPatientNumber;
        private System.Windows.Forms.Label lblPatientNumber;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.TextBox txtMedicalHistory;
        private System.Windows.Forms.Label lblMedicalHistory;
        private System.Windows.Forms.ListView lvPrescriptions;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ColumnHeader clmMedicine;
        private System.Windows.Forms.ListView lvNotes;
        private System.Windows.Forms.ColumnHeader clmDate2;
        private System.Windows.Forms.ColumnHeader clmNote;
        private System.Windows.Forms.ListView lvTests;
        private System.Windows.Forms.ColumnHeader clmDate3;
        private System.Windows.Forms.ColumnHeader clmTest2;
        private System.Windows.Forms.ColumnHeader clmResult;
        private System.Windows.Forms.ColumnHeader clmNotes2;
    }
}