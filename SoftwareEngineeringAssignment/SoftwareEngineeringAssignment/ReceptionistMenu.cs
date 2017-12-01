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
    public partial class ReceptionistMenu : Form
    {
        Staff m_s;
        Form f;
        public ReceptionistMenu(Staff p_s)
        {
            InitializeComponent();
            m_s = p_s;
            lblName.Text = "StaffID: " + m_s.getStaffID;
            WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// Will take you to the form to edit an existing appointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditAppointment_Click(object sender, EventArgs e)
        {
            f = new AppointmentSearch(m_s);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// Will take you to the form to register a patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegisterPatient_Click(object sender, EventArgs e)
        {
            f = new RegisterPatient(m_s);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// Will take you to the form to extend a perscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExtendPerscription_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindPatient_Click(object sender, EventArgs e)
        {
            f = new PatientSearch(m_s);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            f = new ViewStaff(m_s);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
