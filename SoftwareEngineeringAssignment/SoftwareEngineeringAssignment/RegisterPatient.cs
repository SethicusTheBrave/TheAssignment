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
        BusinessMetaLayer instance;
        public RegisterPatient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            instance.registerPatient(txtFirstName.Text, txtLastName.Text)
        }
    }
}
