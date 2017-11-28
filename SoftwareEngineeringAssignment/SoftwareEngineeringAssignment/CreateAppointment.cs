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
        int staffID = 0;
        List<DateTime> dateList = new List<DateTime>();
        //You can't remove any values from the datelist inside the foreach so i'm storing the values that need to be removed in a list and removing them afterwards
        List<DateTime> removeList = new List<DateTime>();
        List<Staff> staffList = new List<Staff>();
        /// <summary>
        /// The form used to create an appointment
        /// </summary>
        /// <param name="p_s"></param>
        /// <param name="p_p"></param>
        public CreateAppointment(Staff p_s, Patient p_p)
        {
            InitializeComponent();
            m_s = p_s;
            m_p = p_p;
            staffList = instance.getStaff();
            LoadDetails();
        }
        /// <summary>
        /// Used to load all the form data. Such as the Patients details.
        /// </summary>
        private void LoadDetails()
        {
            lblName.Text = "StaffID: " + m_s.getStaffID.ToString();
            txtFirstName.Text = m_p.getFirstName;
            txtLastName.Text = m_p.getLastName;
            txtPatientNumber.Text = m_p.getPatientID.ToString();

            foreach(Staff s in staffList)
            {
                cbStaffMember.Items.Add(s.getFirstName + " " + s.getLastName);
            }
            ComboBoxTimes();
        }
        /// <summary>
        /// Used to populate with combobox with dates and times that are not already taken.
        /// </summary>
        private void ComboBoxTimes()
        {
            DateTime startTime = calDate.SelectionStart.AddHours(7);
            DateTime endTime = calDate.SelectionStart.AddHours(19);

            while (startTime < endTime)
            {
                dateList.Add(startTime);
                startTime = startTime.AddMinutes(10);
            }
            List<Appointment> databaseAppointments = instance.getAppointments();
            removeList.Clear();
            foreach (Staff s in staffList)
            {
                if (cbStaffMember.Text == s.getFirstName + " " + s.getLastName)
                {
                    staffID = s.getStaffID;
                }
            }
            foreach (Appointment a in databaseAppointments)
            {
                foreach (DateTime d in dateList)
                {
                    if (a.getDateTime.ToString() == d.ToString())
                    {
                        if (a.getStaffID == staffID)
                        {
                            removeList.Add(d);
                        }
                    }
                }
            }
            foreach (DateTime d in removeList)
            {
                dateList.Remove(d);
            }
            removeList.Clear();
            foreach (DateTime d in dateList)
            {
                cbTime.Items.Add(d.ToShortTimeString());
            }
        }
        /// <summary>
        /// Takes all of the information given and adds it to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            if (cbTime.Text != null || cbTime.Text != "")
            {
                int staffNum=0;
                foreach(Staff s in staffList)
                {
                    if (cbStaffMember.Text == s.getFirstName + " " + s.getLastName)
                    {
                        staffNum = s.getStaffID;
                    }
                }
                DateTime dt = Convert.ToDateTime(cbTime.Text);
                instance.ExecuteQuery("INSERT INTO Appointments(AppointmentID, AppointmentDate, StaffID, PatientID) values (NULL,'" + instance.sanitize(dt.ToString("yyyy-MM-dd h:mm")) + "'," + staffNum + "', '" + m_p.getPatientID + ");");
                this.Close();
            }
            MessageBox.Show("Invalid Data Entered. Please check your input.", "Invalid Input");
        }
        /// <summary>
        /// If the date on the calender is changed it will clear all the dates and times in the list and combobox and repopulate them both.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            cbTime.Items.Clear();
            dateList.Clear();
            ComboBoxTimes();
        }

        private void cbStaffMember_TextChanged(object sender, EventArgs e)
        {
            foreach(Staff s in staffList)
            {
                if (cbStaffMember.Text == s.getFirstName + " " + s.getLastName)
                {
                    lblDate.Visible = true;
                    lblTime.Visible = true;
                    cbTime.Visible = true;
                    calDate.Visible = true;
                }
            }
            dateList.Clear();
            ComboBoxTimes();
        }
    }
}
