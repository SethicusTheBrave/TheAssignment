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
        CreateAppointment frmCA;
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        Patient m_p;
        Staff m_s;
        List<Patient> m_patientList;
        public PatientMenu(List<Patient> p_patientList, Staff p_s)
        {
            InitializeComponent();
            m_patientList = p_patientList;
            m_p = p_patientList.ElementAt(0);
            m_s = p_s;
            loadDetails();
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
                btnPresent.Visible = false;
                if (m_patientList != null)
                    btnNext.Visible = true;
                else
                btnNext.Visible = false;
            }
            else if(m_s.getType == "Receptionist")
            {
                btnBookAppointment.Visible = true;
                btnNewNote.Visible = false;
                btnNewPrescription.Visible = false;
                btnNewTest.Visible = false;
                btnNext.Visible = false;
                btnPresent.Visible = true;
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            instance.PatientStatusUpdate(m_patientList.ElementAt(0).getPatientID, false);
            m_patientList.RemoveAt(0);

            //display new patients details
            //-Ryan
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            frmCA = new CreateAppointment(m_s, m_p);
            this.Hide();
            frmCA.ShowDialog();
            this.Show();
        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            m_p.getPresent = true;
            instance.PatientStatusUpdate(m_p.getPatientID, true);
        }
    }
}
