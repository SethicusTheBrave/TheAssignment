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
        DoctorTODO frmTODO = new DoctorTODO();
        PatientMenu frmPatientMenu = new PatientMenu();
        public DoctorMenu()
        {
            InitializeComponent();
        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            //Hides the doctor menu then displays the Patient Search Menu
            this.Hide();
            frmPatientSearch.ShowDialog();
            this.Show();
        }

        private void btnTodoList_Click(object sender, EventArgs e)
        {
            //Hides the doctor menu then displays the To Do list for the doctor
            this.Hide();
            frmTODO.ShowDialog();
            this.Show();
        }

        private void btnConsoltation_Click(object sender, EventArgs e)
        {
            //Hides the Doctor menu then opens the patient menu which the doctor is currently seeing
            this.Hide();
            frmPatientMenu.ShowDialog();
            this.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
