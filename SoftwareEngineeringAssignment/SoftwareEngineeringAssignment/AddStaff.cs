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
        /// <summary>
        /// Used to add a staff member to the database.
        /// </summary>
        public AddStaff()
        {
            InitializeComponent();
            cbStaffType.Items.Add("Doctor");
            cbStaffType.Items.Add("Receptionist");
            cbStaffType.Items.Add("Manager");
        }
        /// <summary>
        /// Uploads all of the given information to the database to create a new staff member.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            instance.ExecuteQuery("INSERT INTO Staff(StaffID, FirstName, LastName, Address, Postcode, Password, EmailAddress, StaffType, PhoneNumber) VALUES(NULL, '" + instance.sanitize(txtFirstName.Text) + "', '" + instance.sanitize(txtLastName.Text) + "', '" + instance.sanitize(txtAddress.Text) + "', '" + instance.sanitize(txtPostcode.Text) + "', '" + instance.encrypt(txtPassword.Text) + "', '" + instance.sanitize(txtEmailAddress.Text) + "', '" + instance.sanitize(cbStaffType.Text) + "', '" + instance.sanitize(txtPhoneNumber.Text) + "');");
        }
        /// <summary>
        /// Closes the form and takes you back to the previous menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
