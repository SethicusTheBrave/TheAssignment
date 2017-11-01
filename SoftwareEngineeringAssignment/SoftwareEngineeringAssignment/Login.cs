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
        //MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        //UTF8Encoding utf8 = new UTF8Encoding();
        //TripleDESCryptoServiceProvider tDES = new TripleDESCryptoServiceProvider();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //tDES.Key = md5.ComputeHash(utf8.GetBytes(txtPassword));
            //tDES.Mode = CipherMode.ECB;
            //tDES.Padding = PaddingMode.PKCS7;
            //ICryptoTransform trans = tDES.CreateEncryptor();
            //DO MORE ENCRYPTION LATER

        }
    }
}
