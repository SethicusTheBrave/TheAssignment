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
        }

        private void btnViewCurrentStaff_Click(object sender, EventArgs e)
        {
            f = new ViewStaff(m_s);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnViewStaffSchedule_Click(object sender, EventArgs e)
        {

        }

        private void btnEditStaffSchedule_Click(object sender, EventArgs e)
        {

        }

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
