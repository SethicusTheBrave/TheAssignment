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
        public ViewStaff(Staff p_s)
        {
            InitializeComponent();
            m_s = p_s;
            lblName.Text = "StaffID: " + m_s.getStaffID;
            LoadStaff();
        }
        private void LoadStaff()
        {
            DataSet ds = instance.getStaff();
            DataTable table = ds.Tables[0];
            this.dgvStaff.DataSource = table;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
