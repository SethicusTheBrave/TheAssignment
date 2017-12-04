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
    public partial class Drugs : Form
    {
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        List<Medicine> medList;
        public Drugs()
        {
            InitializeComponent();
        }
        private void loadDugs()
        {
            medList = instance.getAllMedicine();
            lvDrugs.Clear();
            lvDrugs.Columns.Add("DrugID");
            lvDrugs.Columns.Add("DrugName");
            lvDrugs.Columns.Add("DrugDescription");
            foreach(Medicine m in medList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.getMedicineID.ToString();
                lvi.Text = m.getMedicineName.ToString();
                lvi.Text = m.getMedicineDescription.ToString();
                lvDrugs.Items.Add(lvi);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
