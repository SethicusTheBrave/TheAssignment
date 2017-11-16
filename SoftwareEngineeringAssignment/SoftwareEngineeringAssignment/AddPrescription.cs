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
    public partial class AddPrescription : Form
    {
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        private Patient m_p;
        private Staff m_s;
        private List<Medicine> medList = new List<Medicine>();
        public AddPrescription(Patient p_p, Staff p_s)
        {
            InitializeComponent();
            m_p = p_p;
            m_s = p_s;
            lblName.Text = "Staff ID: " + m_s.getStaffID;
            fillPatientDetails();
            fillDrugs();
        }
        private void fillPatientDetails()
        {
            txtFirstName.Text = m_p.getFirstName;
            txtLastName.Text = m_p.getLastName;
            txtFromDate.Text = DateTime.Now.ToShortDateString();
            txtPatientNumber.Text = m_p.getPatientID.ToString();
        }
        private void fillDrugs()
        {
            medList = instance.getAllMedicine();
            foreach(Medicine m in medList)
            {
                cbDrug.Items.Add(m.getMedicineName);
            }
        }
        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            double weeks = 0, medID=0;
            if (cbDrug.Text != null && cbDrug.Text != "")
            {
                foreach (Medicine m in medList)
                {
                    if(m.getMedicineName == cbDrug.Text)
                    {
                        medID = m.getMedicineID;
                    }
                }

                if (cbToDate.Text == "1 Week")
                {
                    weeks = 7;
                }
                else if (cbToDate.Text == "2 Weeks")
                {
                    weeks = 14;
                }
                else if (cbToDate.Text == "3 Weeks")
                {
                    weeks = 21;
                }
                else if (cbToDate.Text == "4 Weeks")
                {
                    weeks = 28;
                }
                if (cbToDate.Text != null && cbToDate.Text != "")
                {
                    instance.ExecuteQuery("INSERT INTO MedicineLink (StartDate, EndDate, MedicineID, PatientID) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.AddDays(weeks).ToString("yyyy-MM-dd HH:mm:ss") + "', '" + medID + "', '" + m_p.getPatientID + "');");
                    this.Close();
                }
            }
        }
    }
}
