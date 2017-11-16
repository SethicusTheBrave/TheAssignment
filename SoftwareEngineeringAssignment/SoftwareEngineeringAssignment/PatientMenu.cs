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
    public partial class PatientMenu : Form
    {
        Form f;
        private DateTime dt;
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        List<Appointment> appointmentList = new List<Appointment>();
        List<Medicine> medicineList = new List<Medicine>();
        List<PatientNotes> notesList = new List<PatientNotes>();
        List<Test> testList = new List<Test>();
        Patient m_p;
        Staff m_s;
        List<Patient> m_patientList;

        //This constructor will be entered if you come from consoltation in the doctor menu
        public PatientMenu(List<Patient> p_patientList, Staff p_s)
        {
            InitializeComponent();
            m_patientList = p_patientList;
            m_p = p_patientList.ElementAt(0);
            m_s = p_s;
            loadMenuDetails();
            loadPatientDetails();
        }
        //This constructor will be entered if you come from the patient search part of the doctor or receptionist menu's
        public PatientMenu(Patient p_p, Staff p_s)
        {
            InitializeComponent();
            m_p = p_p;
            m_s = p_s;
            lblName.Text = "StaffID: " + m_s.getStaffID;
            lblDoctor.Text = m_s.getType;
            loadMenuDetails();
            loadPatientDetails();
        }
        //This will hide buttons that certain users are not supposed to have access to 
        private void loadMenuDetails()
        {
            WindowState = FormWindowState.Maximized;

            if (m_s.getType == "Doctor")
            {
                btnBookAppointment.Visible = false;
                btnNewNote.Visible = true;
                btnNewPrescription.Visible = true;
                btnNewTest.Visible = true;
                btnPresent.Visible = false;
                if (m_patientList != null)
                    btnNext.Visible = true;
                else
                btnNext.Visible = false;
            }
            else if(m_s.getType == "Receptionist")
            {
                btnBookAppointment.Visible = true;
                btnNewNote.Visible = false;
                btnNewPrescription.Visible = false;
                btnNewTest.Visible = false;
                btnNext.Visible = false;

                //Only show the button if they have an appointment in the next hour.
                appointmentList = instance.getAppointments();
                bool isSoon = false;
                foreach(Appointment a in appointmentList)
                {
                    dt = DateTime.Now;
                    if(a.getPatientID == m_p.getPatientID)
                    {
                        if (a.getDateTime < dt.AddHours(1))
                        {
                            isSoon = true;
                        }
                    }
                }
                if (isSoon)
                    btnPresent.Visible = true;
            }
            if (m_s.getType == "Nurse")
            {
                btnBookAppointment.Visible = false;
                btnNewNote.Visible = true;
                btnNewPrescription.Visible = false;
                btnNewTest.Visible = true;
                btnPresent.Visible = false;
                if (m_patientList != null)
                    btnNext.Visible = true;
                else
                    btnNext.Visible = false;
            }
        }
        private void loadPatientDetails()
        {
            txtPatientNumber.Text = m_p.getPatientID.ToString();
            txtFirstName.Text = m_p.getFirstName;
            txtLastName.Text = m_p.getLastName;
            txtMedicalHistory.Text = m_p.getMedicalHistory;

            notesList = instance.getPatientNotes(m_p.getPatientID);
            lvNotes.Clear();
            lvNotes.Columns.Add("Date",100);
            lvNotes.Columns.Add("Note", 200);
            foreach (PatientNotes n in notesList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = n.getDate.ToShortDateString().ToString();
                lvi.SubItems.Add(n.getNote);
                lvNotes.Items.Add(lvi);
            }

            medicineList = instance.GetPrescriptions(m_p.getPatientID);
            lvPrescriptions.Clear();
            lvPrescriptions.Columns.Add("Start Date", 100);
            lvPrescriptions.Columns.Add("End Date", 100);
            lvPrescriptions.Columns.Add("Medicine", 200);
            foreach (Medicine m in medicineList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.getStartDate.ToShortDateString().ToString();
                lvi.SubItems.Add(m.getEndDate.ToShortDateString().ToString());
                lvi.SubItems.Add(m.getMedicineName);
                lvPrescriptions.Items.Add(lvi);
            }


            testList = instance.getPatientTests(m_p.getPatientID);
            lvTests.Clear();
            lvTests.Columns.Add("Date", 100);
            lvTests.Columns.Add("Test", 200);
            lvTests.Columns.Add("Result", 300);
            foreach (Test t in testList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = t.getDate.ToShortDateString().ToString();
                lvi.SubItems.Add(t.getTestName);
                lvi.SubItems.Add(t.getResult);
                lvTests.Items.Add(lvi);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            instance.PatientStatusUpdate(m_patientList.ElementAt(0).getPatientID, false);
            m_patientList.RemoveAt(0);
            if(null != m_patientList.ElementAt(0))
            {
                m_p = m_patientList.ElementAt(0);
                loadPatientDetails();
            }
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            f = new CreateAppointment(m_s, m_p);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            m_p.getPresent = true;
            instance.PatientStatusUpdate(m_p.getPatientID, true);
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            string newNote = Microsoft.VisualBasic.Interaction.InputBox("Enter Note", "New Note", "");
            if (newNote != null && newNote != "")
            {
                instance.ExecuteQuery("INSERT INTO Notes (NotesID, Note, Date, PatientID) VALUES (NULL,'" + newNote + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," + m_p.getPatientID + ");");
                loadPatientDetails();
            }
        }

        private void btnNewPrescription_Click(object sender, EventArgs e)
        {
            f = new AddPrescription(m_p, m_s);
            f.ShowDialog();
        }

        private void btnNewTest_Click(object sender, EventArgs e)
        {

        }
    }
}
