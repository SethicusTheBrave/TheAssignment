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

        /// <summary>
        /// This constructor will be entered if the doctor clicks the consoltation button 
        /// </summary>
        /// <param name="p_patientList">The list of patients that need to be seen</param>
        /// <param name="p_s">The currently signed in staff member</param>
        public PatientMenu(List<Patient> p_patientList, Staff p_s)
        {
            InitializeComponent();
            m_patientList = p_patientList;
            m_p = p_patientList.ElementAt(0);
            m_s = p_s;
            loadMenuDetails();
            loadPatientDetails();
        }
        /// <summary>
        /// This constructor is entered if the doctor or receptionist enters this menu through the patient search form.
        /// </summary>
        /// <param name="p_p">The patient that was searched for.</param>
        /// <param name="p_s">The currently signed in staff member.</param>
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
        /// <summary>
        /// hides all of the buttons and information that the signed in staff member shouldn't see.
        /// </summary>
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
        /// <summary>
        /// Will load all of the patients information to the textfiles and get all of the needed information from the database.
        /// </summary>
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
        /// <summary>
        /// Closes the current form and goes back to the previous form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Will go to the next patient if the doctor is in consoltation mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// The book appointment button that the receptionist can press at any time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            f = new CreateAppointment(m_s, m_p);
            f.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// Can mark a patient as currently present if they have an appointment within the next hour.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPresent_Click(object sender, EventArgs e)
        {
            m_p.getPresent = true;
            instance.PatientStatusUpdate(m_p.getPatientID, true);
            MessageBox.Show("This Patient has been marked as present","Patient is now Present");
        }
        /// <summary>
        /// Will create a new note on the patient and upload it to the database. Before refreshing the patient information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewNote_Click(object sender, EventArgs e)
        {
            string newNote = Microsoft.VisualBasic.Interaction.InputBox("Enter Note", "New Note", "");
            if (newNote != null && newNote != "")
            {
                instance.ExecuteQuery("INSERT INTO Notes (NotesID, Note, Date, PatientID) VALUES (NULL,'" + newNote + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," + m_p.getPatientID + ");");
                loadPatientDetails();
            }
        }
        /// <summary>
        /// Will open up a form to assign a new prescription to the patient.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewPrescription_Click(object sender, EventArgs e)
        {
            f = new AddPrescription(m_p, m_s);
            f.ShowDialog();
            loadPatientDetails();
        }
        /// <summary>
        /// Will open up a form to assign a new test to the patient.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewTest_Click(object sender, EventArgs e)
        {
            f = new AddTest(m_p, m_s);
            f.ShowDialog();
            loadPatientDetails();
        }
    }
}
