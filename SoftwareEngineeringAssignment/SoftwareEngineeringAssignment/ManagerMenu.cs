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
    public partial class ManagerMenu : Form
    {
        Form f;
        Staff m_s;
        public ManagerMenu(Staff p_s)
        {
            InitializeComponent();
            m_s = p_s;
            lblName.Text = "StaffID: " + m_s.getStaffID;
            WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// Will show all of the staff that currently exist in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewCurrentStaff_Click(object sender, EventArgs e)
        {
            f = new ViewStaff(m_s);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// will take you to the staff schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewStaffSchedule_Click(object sender, EventArgs e)
        {
            f = new StaffSchedule(m_s);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnEditStaffSchedule_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Will take you to a form to add a staff member to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            f = new AddStaff();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
