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
    public partial class AddTest : Form
    {
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        List<Test> testList = new List<Test>();
        Patient m_p;
        Staff m_s;
        public AddTest(Patient p_p, Staff p_s)
        {
            InitializeComponent();
            m_p = p_p;
            m_s = p_s;
            lblName.Text = "Staff ID: " + m_s.getStaffID;
            loadDetails();
        }
        private void loadDetails()
        {
            txtPatientNumber.Text = m_p.getPatientID.ToString();
            txtFirstName.Text = m_p.getFirstName;
            txtLastName.Text = m_p.getLastName;

            testList = instance.getAllTests();
            cbTest.Items.Clear();
            foreach(Test t in testList)
            {
                cbTest.Items.Add(t.getTestName);
            }
        }
        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            DateTime dt = clDate.SelectionStart;
            int testID=0;
            foreach(Test t in testList)
            {
                if(t.getTestName == cbTest.Text)
                {
                    testID = t.getTestID;
                }
            }
            instance.ExecuteQuery("INSERT INTO testlink VALUES('" + dt.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + testID + "', '" + m_p.getPatientID + "','" + txtResults.Text + "');");
            this.Close();
        }
    }
}
