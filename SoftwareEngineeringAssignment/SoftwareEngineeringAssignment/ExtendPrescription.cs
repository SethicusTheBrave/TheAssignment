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
    public partial class ExtendPrescription : Form
    {
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        List<Patient> patientList;

        public ExtendPrescription()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Upon double clicking a cell will open up a patient search with the details of the patient in question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgExtention_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            patientList = instance.patientList();
            foreach (Patient p in patientList)
            {

            }
        }
    }
}
