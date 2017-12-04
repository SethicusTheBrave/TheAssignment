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
    public partial class RegisterPatient : Form
    {
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        Staff m_s;
        public RegisterPatient(Staff p_s)
        {
            InitializeComponent();
            m_s = p_s;
            lblName.Text = "StaffID: " + m_s.getStaffID;
            WindowState = FormWindowState.Maximized;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime dt = clDoB.SelectionStart;
            instance.ExecuteQuery("INSERT INTO patient VALUES(NULL, '" + instance.sanitize(txtLastName.Text) + "', '" + instance.sanitize(txtFirstName.Text) + "', '" + instance.sanitize(txtAddress.Text) + "', '" + instance.sanitize(txtPostcode.Text) + "', '" + instance.sanitize(txtCountry.Text) + "', '" + instance.sanitize(dt.ToString("yyyy-MM-dd HH:mm:ss")) + "', '" + instance.sanitize(txtMedicalHistory.Text) + "', '" + instance.sanitize(txtEmail.Text) + "', '" + instance.sanitize(txtPhone.Text) + "' , '0');");
        }
    }
}
