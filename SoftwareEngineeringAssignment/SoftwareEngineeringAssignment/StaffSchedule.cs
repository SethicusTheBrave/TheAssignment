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
    public partial class StaffSchedule : Form
    {
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        List<Staff> StaffList = new List<Staff>;
        Staff m_s;
        /// <summary>
        /// View the staff schedule.
        /// </summary>
        public StaffSchedule(Staff p_s)
        {
            InitializeComponent();
            m_s = p_s;
            loadSchedule();
        }
        private void loadSchedule()
        {
            LstStaffSchedule.Clear();
            LstStaffSchedule.Columns.Add("Staff ID", 100);
            LstStaffSchedule.Columns.Add("First Name", 200);
            LstStaffSchedule.Columns.Add("Last Name", 200);
            LstStaffSchedule.Columns.Add("Monday", 100);
            LstStaffSchedule.Columns.Add("Tuesday", 100);
            LstStaffSchedule.Columns.Add("Wednesday", 100);
            LstStaffSchedule.Columns.Add("Thursday", 100);
            LstStaffSchedule.Columns.Add("Friday", 100);
            LstStaffSchedule.Columns.Add("Saturday", 100);
            LstStaffSchedule.Columns.Add("Sunday", 100);
            foreach (Staff s in StaffList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = s.getStaffID.ToString();
                lvi.Text = s.getFirstName.ToString();
                lvi.Text = s.getLastName.ToString();
                lvi.Text = s.getMonday.ToString();
                lvi.Text = s.getTuesday.ToString();
                lvi.Text = s.getWednesday.ToString();
                lvi.Text = s.getThursday.ToString();
                lvi.Text = s.getFriday.ToString();
                lvi.Text = s.getSaturday.ToString();
                lvi.Text = s.getSunday.ToString();
                LstStaffSchedule.Items.Add(lvi);

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
