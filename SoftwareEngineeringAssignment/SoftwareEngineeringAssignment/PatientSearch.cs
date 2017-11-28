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
        Form f;
        List<Patient> patientList;
        BusinessMetaLayer instance;
        public PatientSearch(Staff p_s)
        {
            InitializeComponent();
            instance = BusinessMetaLayer.instance();
            m_s = p_s;
            lblName.Text = "StaffID: " + m_s.getStaffID;
            lblStaffType.Text = m_s.getType;
        }

        private void btnSearch1_Click_1(object sender, EventArgs e)
        {
            patientList = instance.getPatientList();
            //checks to see if the textbox results match any of the database records
            try
            {
                foreach (Patient p in patientList)
                {

                    if (p.getPatientID == int.Parse(txtPatientNumber.Text))
                    {
                        f = new PatientMenu(p, m_s);
                    }
                }
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Input, Please check your input.", "Invalid User Input");
                txtPatientNumber.Clear();
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            patientList = instance.getPatientList();
            //checks to see if the textbox results match any of the database records
            try
            {
                foreach (Patient p in patientList)
                {
                    if (p.getFirstName == txtFirstName.Text && p.getLastName == txtLastName.Text && p.getDOB == calDOB.SelectionStart)
                    {
                        f = new PatientMenu(p, m_s);
                    }
                }
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Input, Please check your input.", "Invalid User Input");
                txtFirstName.Clear();
                txtLastName.Clear();
            }
        }

        private void btnSearch3_Click(object sender, EventArgs e)
        {
            patientList = instance.getPatientList();
            //checks to see if the textbox results match any of the database records
            try
            {
                foreach (Patient p in patientList)
                {
                    if (p.getFirstName == txtFirstName2.Text && p.getLastName == txtLastName2.Text && p.getPostcode == txtPostcode.Text && p.getAddress == txtAddress.Text)
                    {
                        f = new PatientMenu(p, m_s);
                    }
                }
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Input, Please check your input.", "Invalid User Input");
                txtFirstName2.Clear();
                txtLastName2.Clear();
                txtAddress.Clear();
                txtPostcode.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
