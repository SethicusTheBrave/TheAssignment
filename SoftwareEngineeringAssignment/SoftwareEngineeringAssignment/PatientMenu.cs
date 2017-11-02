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
        public PatientMenu()
        {
            InitializeComponent();
        }
        public PatientMenu(Patient p)
        {
            InitializeComponent();
            m_p = p;
            loadDetails();
        }
        private void loadDetails()
        {
            txtPatientNumber.Text = m_p.getPatientID;
            txtFirstName.Text = m_p.getFirstName;
            txtLastName.Text = m_p.getLastName;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
