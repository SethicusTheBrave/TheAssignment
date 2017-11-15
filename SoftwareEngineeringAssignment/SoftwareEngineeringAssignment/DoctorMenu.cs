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
        List<Patient> m_patientList = new List<Patient>();
        PatientSearch frmPatientSearch;
        DoctorTODO frmTODO = new DoctorTODO();
        PatientMenu frmPatientMenu;
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        public DoctorMenu(Staff p_s)
        {
            InitializeComponent();
            m_s = p_s;
            lblName.Text = "StaffID: " + m_s.getStaffID;
            lblDoctor.Text = m_s.getType;
        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            frmPatientSearch = new PatientSearch(m_s);
            //Hides the doctor menu then displays the Patient Search Menu
            this.Hide();
            frmPatientSearch.ShowDialog();
            this.Show();
        }

        private void btnTodoList_Click(object sender, EventArgs e)
        {
            //Hides the doctor menu then displays the To Do list for the doctor
            this.Hide();
            frmTODO.ShowDialog();
            this.Show();
        }

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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //will close this menu and go back to the previous menu
            this.Close();
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {

        }
    }
}
