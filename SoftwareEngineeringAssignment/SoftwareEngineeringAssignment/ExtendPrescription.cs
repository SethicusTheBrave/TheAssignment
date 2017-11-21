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
        Form f;
        Staff m_s;
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        List<Patient> patientList;
        List<Medicine> medicineList = new List<Medicine>();

        public ExtendPrescription()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        private void loadPerscriptions()
        {
            medicineList = instance.GetPrescriptions(m_p.getPatientID);
            lvDrugs.Clear();
            lvDrugs.Columns.Add("Start Date", 100);
            lvDrugs.Columns.Add("End Date", 100);
            lvDrugs.Columns.Add("Medicine", 200);
            foreach (Medicine m in medicineList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.getStartDate.ToShortDateString().ToString();
                lvi.SubItems.Add(m.getEndDate.ToShortDateString().ToString());
                lvi.SubItems.Add(m.getMedicineName);
                lvDrugs.Items.Add(lvi);
            }
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {

        }
    }
}
