using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SoftwareEngineeringAssignment
{
    public partial class Login : Form
    {
        Form f;
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When the button is pressed submit is called to check the login information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Submit();
        }
        /// <summary>
        /// Will check the staffID and passwords written in the textboxes with the version in the database.
        /// </summary>
        private void Submit()
        {
            if (txtStaffID.Text == null || txtStaffID.Text == "" || txtPassword.Text == null || txtPassword.Text == "")
            {
                MessageBox.Show("Invalid StaffID or Password");
            }
            else
            {
                //required variables and objects to make the below code work correctly.
                Staff s = null;
                //Attempts to login with the provided StaffID and the encrypted version of the provided password.
                try
                {
                    s = instance.Login(int.Parse(txtStaffID.Text), txtPassword.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid User input. Please check your input and try again", "Invalid Input");
                    txtPassword.Clear();
                    txtStaffID.Clear();
                    txtStaffID.Focus();
                }
                //if a result is found it will look at the returned staffType to determine what type of staff member logged in and show them the correct menu.
                if (null != s)
                {
                    if (s.getType == "Doctor")
                    {
                        f = new DoctorMenu(s);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        txtPassword.Clear();
                        txtStaffID.Clear();
                        txtStaffID.Focus();
                    }
                    else if (s.getType == "Receptionist")
                    {
                        f = new ReceptionistMenu(s);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        txtPassword.Clear();
                        txtStaffID.Clear();
                        txtStaffID.Focus();
                    }
                    else if (s.getType == "Manager")
                    {
                        f = new ManagerMenu(s);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        txtPassword.Clear();
                        txtStaffID.Clear();
                        txtStaffID.Focus();
                    }
                    else if (s.getType == "Nurse")
                    {
                        f = new DoctorMenu(s);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        txtPassword.Clear();
                        txtStaffID.Clear();
                        txtStaffID.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed", "Invalid StaffID or Password");
                    }
                }
            }
        }
        /// <summary>
        /// Of the focus is on the password textbox and enter is pressed will submit the information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Submit();
            }
        }
        /// <summary>
        /// if the focus is on the staffID textbox and tab is pressed will go to the password textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStaffID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtPassword.Focus();
            }
        }
    }
}
