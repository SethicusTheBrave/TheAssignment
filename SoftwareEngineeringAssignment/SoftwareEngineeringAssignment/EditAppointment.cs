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
    public partial class EditAppointment : Form
    {
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        //The currently logged in staff member
        Staff m_s;
        //The staff member who is part of the appointment
        Staff m_as;
        Appointment m_a;
        Patient m_p;
        int staffID = 0;
        List<DateTime> dateList = new List<DateTime>();
        //You can't remove any values from the datelist inside the foreach so i'm storing the values that need to be removed in a list and removing them afterwards
        List<DateTime> removeList = new List<DateTime>();
        List<Staff> staffList = new List<Staff>();
        public EditAppointment(Staff p_s, Appointment p_a, Patient p_p, Staff p_as)
        {
            InitializeComponent();
            m_s = p_s;
            m_a = p_a;
            m_p = p_p;
            m_as = p_as;
            lblName.Text = "StaffID: " + m_s.getStaffID;
            staffList = instance.getStaff();
            UpdateDetails();
        }

        private void UpdateDetails()
        {
            txtCurrentTime.Text = m_a.getDateTime.ToShortDateString() + " " + m_a.getDateTime.ToShortTimeString();
            txtFirstName.Text = m_p.getFirstName;
            txtLastName.Text = m_p.getLastName;
            txtCurrentStaff.Text = m_as.getFirstName + " " + m_as.getLastName;
            txtPatientNumber.Text = m_p.getPatientID.ToString();
            foreach(Staff s in staffList)
            {
                cbNewStaff.Items.Add(s.getFirstName + " " + s.getLastName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
            foreach(Staff s in staffList)
            {
                if (cbNewStaff.Text == s.getFirstName + " " + s.getLastName)
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
            foreach(DateTime d in dateList)
            {
                cbNewTime.Items.Add(d.ToShortTimeString());
            }
        }

        private void calDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            cbNewTime.Items.Clear();
            dateList.Clear();
            ComboBoxTimes();
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            if (cbNewTime.Text != null || cbNewTime.Text != "")
            {
                DateTime dt = Convert.ToDateTime(cbNewTime.Text);
                instance.ExecuteQuery("UPDATE Appointments SET AppointmentDate='" + dt.ToString("yyyy-MM-dd h:mm") + "', StaffID='" + staffID + "' WHERE AppointmentID='" + m_a.getAppointmentID + "';");
            }
        }

        private void cbNewStaff_TextChanged(object sender, EventArgs e)
        {
            cbNewTime.Items.Clear();
            dateList.Clear();
            cbNewTime.Text = "";
            ComboBoxTimes();
        }
    }
}
