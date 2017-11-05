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
    public partial class AddStaff : Form
    {
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        public AddStaff()
        {
            InitializeComponent();
            cbStaffType.Items.Add("Doctor");
            cbStaffType.Items.Add("Receptionist");
            cbStaffType.Items.Add("Manager");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            instance.ExecuteQuery("INSERT INTO Staff(StaffID, FirstName, LastName, Address, Postcode, Password, EmailAddress, StaffType, PhoneNumber) VALUES(NULL, '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtAddress.Text + "', '" + txtPostcode.Text + "', '" + instance.encrypt(txtPassword.Text) + "', '" + txtEmailAddress.Text + "', '" + cbStaffType.Text + "', '" + txtPhoneNumber.Text + "');");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
