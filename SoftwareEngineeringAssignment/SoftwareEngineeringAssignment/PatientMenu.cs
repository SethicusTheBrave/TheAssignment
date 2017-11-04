using System;
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
    public partial class PatientMenu : Form
    {
        Patient m_p;
        Staff m_s;
        public PatientMenu()
        {
            InitializeComponent();
        }
        public PatientMenu(Patient p_p, Staff p_s)
        {
            InitializeComponent();
            m_p = p_p;
            m_s = p_s;
            loadDetails();
        }
        private void loadDetails()
        {
            txtPatientNumber.Text = m_p.getPatientID;
            txtFirstName.Text = m_p.getFirstName;
            txtLastName.Text = m_p.getLastName;
            if(m_s.getType == "Doctor")
            {
                btnBookAppointment.Visible = false;
                btnNewNote.Visible = true;
                btnNewPrescription.Visible = true;
                btnNewTest.Visible = true;
                btnNext.Visible = false;
            }
            else if(m_s.getType == "Receptionist")
            {
                btnBookAppointment.Visible = true;
                btnNewNote.Visible = false;
                btnNewPrescription.Visible = false;
                btnNewTest.Visible = false;
                btnNext.Visible = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}
