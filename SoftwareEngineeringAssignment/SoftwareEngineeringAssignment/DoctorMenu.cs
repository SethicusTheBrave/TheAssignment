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
    public partial class DoctorMenu : Form
    {
        Staff m_s;
        Form f;
        List<Patient> m_patientList = new List<Patient>();
        PatientSearch frmPatientSearch;
        PatientMenu frmPatientMenu;
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        /// <summary>
        /// The main menu for a doctor.
        /// </summary>
        /// <param name="p_s"></param>
        public DoctorMenu(Staff p_s)
        {
            InitializeComponent();
            m_s = p_s;
            lblName.Text = "StaffID: " + m_s.getStaffID;
            lblDoctor.Text = m_s.getType;
        }
        /// <summary>
        /// Will open up the form used to search for a patient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            frmPatientSearch = new PatientSearch(m_s);
            //Hides the doctor menu then displays the Patient Search Menu
            this.Hide();
            frmPatientSearch.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// Will open up the doctors ToDo list. Which is a list of prescriptions that have had extension requests.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTodoList_Click(object sender, EventArgs e)
        {
            //Hides the doctor menu then displays the To Do list for the doctor
            f = new DoctorTODO();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
         /// <summary>
         /// Will start consoltation mode which will allow you to go through patient by patient depending on who is currently here waiting to be seen.
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void btnConsoltation_Click(object sender, EventArgs e)
        {
            //will create a list of all the patients that are currently here and had an appointment with the logged in doctor.
            List<Patient> temp = instance.patientList();
            List<Appointment> appointmentList = instance.getAppointments();
            foreach(Patient p in temp)
            {
                if(p.getPresent)
                {
                    foreach (Appointment a in appointmentList)
                    {
                        if (a.getStaffID == m_s.getStaffID)
                        {
                            m_patientList.Add(p);
                        }
                    }
                }
            }
            if (m_patientList.Count != 0)
            {
                //hides the current form and shows the patientMenu form with the current patients details.
                frmPatientMenu = new PatientMenu(m_patientList, m_s);
                this.Hide();
                frmPatientMenu.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("There are no Patients currently waiting to be seen", "No Patients");
        }
        /// <summary>
        /// Will log you out and allow someone else to login to the system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //will close this menu and go back to the previous menu
            this.Close();
        }
        /// <summary>
        /// Will allow the doctor to add another type of drug to the system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDrug_Click(object sender, EventArgs e)
        {

        }
    }
}
