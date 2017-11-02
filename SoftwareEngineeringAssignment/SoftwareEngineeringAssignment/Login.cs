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
        BusinessMetaLayer instance;
        //MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        //UTF8Encoding utf8 = new UTF8Encoding();
        //TripleDESCryptoServiceProvider tDES = new TripleDESCryptoServiceProvider();
        public Login()
        {
            InitializeComponent();
            instance = BusinessMetaLayer.instance();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //required variables and objects to make the below code work correctly.
            DoctorMenu dm = new DoctorMenu();
            ReceptionistMenu rm = new ReceptionistMenu();
            ManagerMenu mm = new ManagerMenu();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            AesCryptoServiceProvider AES = new AesCryptoServiceProvider();
            string result,encryptedPassword;

            //Encrypts the password using our super secure encryption key
            AES.Key = md5.ComputeHash(utf8.GetBytes("SUPERsecureKEY1"));
            AES.Mode = CipherMode.ECB;
            AES.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = AES.CreateEncryptor();
            encryptedPassword = BitConverter.ToString(trans.TransformFinalBlock(utf8.GetBytes(txtPassword.Text), 0, utf8.GetBytes(txtPassword.Text).Length));

            //Attempts to login with the provided StaffID and the encrypted version of the provided password.
            result = instance.Login(txtStaffID.Text, encryptedPassword);
            //if a result is found it will look at the returned staffType to determine what type of staff member logged in and show them the correct menu.
            if (result == "Doctor")
            {
                this.Hide();
                dm.ShowDialog();
                this.Show();
            }
            else if (result == "Receptionist")
            {
                this.Hide();
                rm.ShowDialog();
                this.Show();
            }
            else if (result == "Manager")
            {
                this.Hide();
                mm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Login Failed", "Invalid StaffID or Password");
            }
        }
    }
}
