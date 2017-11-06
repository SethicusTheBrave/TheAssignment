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
        public ReceptionistMenu(Staff p_s)
        {
            InitializeComponent();
            m_s = p_s;
            lblName.Text = "StaffID: " + m_s.getStaffID;
        }

        /// <summary>
        /// Will take you to the form to create a new appointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Will take you to the form to edit an existing appointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditAppointment_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Will take you to the form to register a patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegisterPatient_Click(object sender, EventArgs e)
        {
            RegisterPatient regPatient = new RegisterPatient();
            this.Hide();
            regPatient.ShowDialog();
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
    }
}
