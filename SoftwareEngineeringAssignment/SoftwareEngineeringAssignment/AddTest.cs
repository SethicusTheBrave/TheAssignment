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
        /// <summary>
        /// Loads the form used to add a test to the patient.
        /// </summary>
        /// <param name="p_p"></param>
        /// <param name="p_s"></param>
        public AddTest(Patient p_p, Staff p_s)
        {
            InitializeComponent();
            m_p = p_p;
            m_s = p_s;
            lblName.Text = "Staff ID: " + m_s.getStaffID;
            loadDetails();
        }
        /// <summary>
        /// Used to load all of the details required for the form. All the Patient information and populates the combobox with all the tests in the database.
        /// </summary>
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
        /// <summary>
        /// Used to send all of the given information to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            int testID=0;
            foreach(Test t in testList)
            {
                if(t.getTestName == cbTest.Text)
                {
                    testID = t.getTestID;
                }
            }
            instance.ExecuteQuery("INSERT INTO testlink VALUES('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + m_p.getPatientID + "', '" + testID + "','" + txtResults.Text + "');");
            this.Close();
        }
    }
}
