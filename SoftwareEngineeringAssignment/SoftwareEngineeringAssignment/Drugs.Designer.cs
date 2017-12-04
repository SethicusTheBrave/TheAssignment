namespace SoftwareEngineeringAssignment
{
    partial class Drugs
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
            this.lvDrugs = new System.Windows.Forms.ListView();
            this.clmDrugdID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmDrugName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDrugDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewDrug = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteDrug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvDrugs
            // 
            this.lvDrugs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDrugdID,
            this.ClmDrugName,
            this.clmDrugDescription});
            this.lvDrugs.Location = new System.Drawing.Point(10, 13);
            this.lvDrugs.Name = "lvDrugs";
            this.lvDrugs.Size = new System.Drawing.Size(880, 569);
            this.lvDrugs.TabIndex = 0;
            this.lvDrugs.UseCompatibleStateImageBehavior = false;
            // 
            // clmDrugdID
            // 
            this.clmDrugdID.Text = "Drug ID";
            // 
            // ClmDrugName
            // 
            this.ClmDrugName.Text = "Drug Name";
            // 
            // clmDrugDescription
            // 
            this.clmDrugDescription.Text = "Drug Description";
            // 
            // btnNewDrug
            // 
            this.btnNewDrug.Location = new System.Drawing.Point(897, 13);
            this.btnNewDrug.Name = "btnNewDrug";
            this.btnNewDrug.Size = new System.Drawing.Size(91, 34);
            this.btnNewDrug.TabIndex = 1;
            this.btnNewDrug.Text = "New Drug";
            this.btnNewDrug.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(998, 557);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteDrug
            // 
            this.btnDeleteDrug.Location = new System.Drawing.Point(897, 54);
            this.btnDeleteDrug.Name = "btnDeleteDrug";
            this.btnDeleteDrug.Size = new System.Drawing.Size(91, 38);
            this.btnDeleteDrug.TabIndex = 3;
            this.btnDeleteDrug.Text = "Delete Drug";
            this.btnDeleteDrug.UseVisualStyleBackColor = true;
            // 
            // Drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1099, 600);
            this.Controls.Add(this.btnDeleteDrug);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewDrug);
            this.Controls.Add(this.lvDrugs);
            this.Name = "Drugs";
            this.Text = "Drugs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDrugs;
        private System.Windows.Forms.ColumnHeader clmDrugdID;
        private System.Windows.Forms.ColumnHeader ClmDrugName;
        private System.Windows.Forms.ColumnHeader clmDrugDescription;
        private System.Windows.Forms.Button btnNewDrug;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteDrug;
    }
}