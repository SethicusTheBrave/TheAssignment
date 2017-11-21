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
    public partial class DoctorTODO : Form
    {
        List<Patient> patientList;
        BusinessMetaLayer instance;
        public DoctorTODO()
        {
            InitializeComponent();
        }
        /// <summary>
        /// When The individual double clicks on a value in the table will open the patient details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            patientList = instance.patientList();

        }
    }
}
