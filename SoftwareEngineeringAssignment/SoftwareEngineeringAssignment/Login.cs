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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Submit();
        }
        private void Submit()
        {
            if (txtStaffID.Text == null || txtStaffID.Text == "" || txtPassword.Text == null || txtPassword.Text == "")
            {
                MessageBox.Show("Invalid StaffID or Password");
            }
            else
            {
                //required variables and objects to make the below code work correctly.
                Staff s;
                
                //Attempts to login with the provided StaffID and the encrypted version of the provided password.
                s = instance.Login(int.Parse(txtStaffID.Text), txtPassword.Text);
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
                    else
                    {
                        MessageBox.Show("Login Failed", "Invalid StaffID or Password");
                    }
                }
            }
        }

        private void txtStaffID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                txtPassword.Focus();
            }
            if(e.KeyCode == Keys.Enter)
            {
                Submit();
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Submit();
            }
            if (e.KeyCode == Keys.Tab)
            {
                btnLogin.Focus();
            }
        }
    }
}
