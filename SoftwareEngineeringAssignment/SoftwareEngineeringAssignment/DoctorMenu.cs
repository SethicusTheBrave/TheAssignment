﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringAssignment
{
    public partial class DoctorMenu : Form
    {
        PatientSearch frmPatientSearch = new PatientSearch();
        public DoctorMenu()
        {
            InitializeComponent();
        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPatientSearch.ShowDialog();
            this.Show();
        }
    }
}
