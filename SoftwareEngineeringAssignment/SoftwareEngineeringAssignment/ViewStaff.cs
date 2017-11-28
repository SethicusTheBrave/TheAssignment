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
    public partial class ViewStaff : Form
    {
        Staff m_s;
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        List<Staff> staffList = new List<Staff>();
        public ViewStaff(Staff p_s)
        {
            InitializeComponent();
            m_s = p_s;
            lblName.Text = "StaffID: " + m_s.getStaffID;
            lblManager.Text = m_s.getType;
            LoadStaff();
        }
        private void LoadStaff()
        {
            staffList = instance.getStaff();
            lstStaff.Items.Clear();

            foreach(Staff s in staffList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = s.getFirstName;
                lvi.SubItems.Add(s.getLastName);
                lvi.SubItems.Add(s.getType);
                lvi.SubItems.Add(s.getEmail);
                lvi.SubItems.Add(s.getPhoneNumber);
                lstStaff.Items.Add(lvi);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
