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
    public partial class PatientSearch : Form
    {
        Staff m_s;
        PatientMenu pm;
        List<Patient> patientList;
        BusinessMetaLayer instance;
        public PatientSearch(Staff p_s)
        {
            InitializeComponent();
            instance = BusinessMetaLayer.instance();
            m_s = p_s;
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            patientList = instance.patientList();
            //checks to see if the textbox results match any of the database records
            foreach (Patient p in patientList)
            {
                if(p.getPatientID == txtPatientNumber.Text)
                {
                    pm = new PatientMenu(p, m_s);
                    this.Hide();
                    pm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Patient not found.","A Patient with the provided details could not be found");
                }
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            patientList = instance.patientList();
            //checks to see if the textbox results match any of the database records
            foreach (Patient p in patientList)
            {
                if (p.getFirstName == txtFirstName.Text && p.getLastName == txtLastName.Text && p.getDOB == calDOB.SelectionStart.ToString())
                {
                    pm = new PatientMenu(p,m_s);
                    this.Hide();
                    pm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Patient not found.", "A Patient with the provided details could not be found");
                }
            }
        }

        private void btnSearch3_Click(object sender, EventArgs e)
        {
            patientList = instance.patientList();
            //checks to see if the textbox results match any of the database records
            foreach (Patient p in patientList)
            {
                if (p.getFirstName == txtFirstName2.Text && p.getLastName == txtLastName2.Text && p.getPostcode == txtPostcode.Text && p.getAddress == txtAddress.Text)
                {
                    pm = new PatientMenu(p,m_s);
                    this.Hide();
                    pm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("PatientID not found.", "A Patient with the provided details could not be found");
                }
            }
        }
    }
}
