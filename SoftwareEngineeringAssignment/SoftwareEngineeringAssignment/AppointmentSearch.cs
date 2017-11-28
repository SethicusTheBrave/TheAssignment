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
    public partial class AppointmentSearch : Form
    {
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        Staff m_s;
        List<Appointment> appointmentList;
        List<Appointment> FilteredList = new List<Appointment>();
        List<Patient> patientList;
        List<Staff> staffList = new List<Staff>();
        Form f;
        public AppointmentSearch(Staff p_s)
        {
            InitializeComponent();
            m_s = p_s;
            lblName.Text = "StaffID: " + m_s.getStaffID;
            lblStaffType.Text = m_s.getType;
            patientList = instance.getPatientList();
            appointmentList = instance.getAppointments();
            staffList = instance.getStaff();
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            FilteredList.Clear();
            cbAppointment.Items.Clear();
            try
            {
                foreach (Appointment a in appointmentList)
                {
                    if (a.getAppointmentID == int.Parse(txtAppointmentNumber.Text))
                    {
                        Patient p=null;
                        foreach(Patient patient in patientList)
                        {
                            if(patient.getPatientID == a.getPatientID)
                            {
                                p = patient;
                            }
                        }
                        cbAppointment.Items.Add(p.getFirstName + " " + p.getLastName + " at " + a.getDateTime.ToShortTimeString() + " on the " + a.getDateTime.ToShortDateString());
                        FilteredList.Add(a);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid User Input", "Invalid Input");
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            FilteredList.Clear();
            cbAppointment.Items.Clear();
            try
            {
                foreach (Appointment a in appointmentList)
                {
                    foreach (Patient p in patientList)
                    {
                        if (a.getPatientID == p.getPatientID)
                        {
                            cbAppointment.Items.Add(p.getFirstName + " " + p.getLastName + " at " + a.getDateTime.ToShortTimeString() + " on the " + a.getDateTime.ToShortDateString());
                            FilteredList.Add(a);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid User Input", "Invalid Input");
            }
        }

        private void btnSearch3_Click(object sender, EventArgs e)
        {
            FilteredList.Clear();
            cbAppointment.Items.Clear();

            try
            {
                foreach (Appointment a in appointmentList)
                {
                    foreach (Patient p in patientList)
                    {
                        if (txtFirstName.Text == p.getFirstName && txtLastName.Text == p.getLastName && clDOB.SelectionStart.ToString() == p.getDOB.ToString())
                        {
                            cbAppointment.Items.Add(p.getFirstName + " " + p.getLastName + " at " + a.getDateTime.ToShortTimeString() + " on the " + a.getDateTime.ToShortDateString());
                            FilteredList.Add(a);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid User Input", "Invalid Input");
            }
        }

        private void cbAppointment_TextChanged(object sender, EventArgs e)
        {
            Patient patient = null;
            Staff staff = null;
            foreach(Patient p in patientList)
            {
                if(p.getPatientID == FilteredList.ElementAt(cbAppointment.SelectedIndex).getPatientID)
                {
                    patient = p;
                }
            }
            foreach(Staff s in staffList)
            {
                if (s.getStaffID == FilteredList.ElementAt(cbAppointment.SelectedIndex).getStaffID)
                {
                    staff = s;
                }
            }
            f = new EditAppointment(m_s, FilteredList.ElementAt(cbAppointment.SelectedIndex), patient, staff);
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
