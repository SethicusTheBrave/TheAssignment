using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringAssignment
{
    public partial class CreateAppointment : Form
    {
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        Staff m_s;
        Patient m_p;
        List<DateTime> dateList = new List<DateTime>();
        public CreateAppointment(Staff p_s, Patient p_p)
        {
            InitializeComponent();
            m_s = p_s;
            m_p = p_p;
            LoadDetails();
            
        }
        private void LoadDetails()
        {
            lblName.Text = "StaffID: " + m_s.getStaffID.ToString();
            txtFirstName.Text = m_p.getFirstName;
            txtLastName.Text = m_p.getLastName;
            txtPatientNumber.Text = m_p.getPatientID.ToString();
            ComboBoxTimes();
        }
        private void ComboBoxTimes()
        {
            DateTime startTime = calDate.SelectionStart.AddHours(7);
            DateTime endTime = calDate.SelectionStart.AddHours(19);

            while(startTime < endTime)
            {
                dateList.Add(startTime);
                startTime = startTime.AddMinutes(10);
            }
            instance.getAppointments();
        }
        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(cbTime.Text);
            instance.ExecuteQuery("INSERT INTO Appointments(AppointmentID, AppointmentDate, PatientID) values (NULL,'" + instance.sanitize(dt.ToString("yyyy-MM-dd h:mm")) + "'," + m_p.getPatientID + ");");
        }

        private void calDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            cbTime.Items.Clear();
            ComboBoxTimes();
        }
    }
}
