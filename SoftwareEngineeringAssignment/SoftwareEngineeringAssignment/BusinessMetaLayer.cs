using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SoftwareEngineeringAssignment
{
    class BusinessMetaLayer
    {
        private DbConection con = DbFactory.instance();
        static private BusinessMetaLayer m_instance = null;

        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        UTF8Encoding utf8 = new UTF8Encoding();
        AesCryptoServiceProvider AES = new AesCryptoServiceProvider();

        private BusinessMetaLayer() { }

        static public BusinessMetaLayer instance()
        {
            if (null == m_instance)
            {
                m_instance = new BusinessMetaLayer();
            }
            return m_instance;

        }
        /// <summary>
        /// encrypts whatever string is sent to it. Such as a password.
        /// </summary>
        /// <param name="toBeEncrypted"></param>
        /// <returns></returns>
        public string encrypt(string toBeEncrypted)
        {
            AES.Key = md5.ComputeHash(utf8.GetBytes("SUPERsecureKEY1")); //key used to encrypt everything
            AES.Mode = CipherMode.ECB;
            AES.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = AES.CreateEncryptor();
            return (BitConverter.ToString(trans.TransformFinalBlock(utf8.GetBytes(toBeEncrypted), 0, utf8.GetBytes(toBeEncrypted).Length)));
        }
        /// <summary>
        /// Uses the passed variables and checks it against the database to see if there is a match and if there is returns the staff member object.
        /// </summary>
        /// <param name="p_StaffID">The entered StaffID number</param>
        /// <param name="p_Password">The entered password.</param>
        /// <returns></returns>
        public Staff Login(int p_StaffID, string p_Password)
        {
            string encrypted;
            encrypted = encrypt(p_Password);
            List<Staff> staffList = new List<Staff>();
            //Will attempt to make a connection with the database.
            if (con.OpenConnection())
            {
                //Will select all of the staffID's and Passwords in the Staff table.
                DbDataReader dr = con.Select("SELECT StaffID, Password, StaffType FROM staff"); 

                //Will create a Staff object for each entry in the table.
                while (dr.Read())
                {
                    Staff s = new Staff();
                    s.getStaffID = dr.GetInt32(0);
                    s.getpassword = dr.GetString(1);
                    s.getType = dr.GetString(2);
                    staffList.Add(s);
                }
                //Closes the database reader and the connection to the database.
                con.CloseConnection();
                dr.Close();
                //Compares the password from the textbox with each entry in the database. 
                if (staffList.Count() > 0)
                {
                    foreach (Staff s in staffList)
                    {
                        if (p_StaffID == s.getStaffID && encrypted == s.getpassword)
                        {
                            Staff loginStaff = new Staff();
                            loginStaff.getStaffID = s.getStaffID;
                            loginStaff.getType = s.getType;
                            return loginStaff;
                        }
                    }
                }
                return null;
            }
            else
            {
                MessageBox.Show("Database Connection Error!", "An Error has occured when attempting to connect to the database. Please contact your network administrator.");
                return null;
            }
        }
        /// <summary>
        /// Returns a list of all the patients in the database.
        /// </summary>
        /// <returns></returns>
        public List<Patient> patientList()
        {
            List<Patient> patientList = new List<Patient>();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM patient");
                //Will create a Staff object for each entry in the table.
                while (dr.Read())
                {
                    Patient p = new Patient();
                    p.getPatientID = dr.GetInt32(0);
                    p.getLastName = dr.GetString(1);
                    p.getFirstName = dr.GetString(2);
                    p.getAddress = dr.GetString(3);
                    p.getPostcode = dr.GetString(4);
                    p.getCountry = dr.GetString(5);
                    p.getDOB = dr.GetDateTime(6);
                    p.getMedicalHistory = dr.GetString(7);
                    p.getPresent = dr.GetBoolean(8);
                    patientList.Add(p);
                }
                con.CloseConnection();
                dr.Close();
                return patientList;
            }
            else
            {
                //Closes the database reader and the connection to the database.
                con.CloseConnection();
                MessageBox.Show("Database Connection Error!", "An Error has occured when attempting to connect to the database. Please contact your network administrator.");
                return null;
            }
        }
        /// <summary>
        /// Returns a list of all the appointments in the database.
        /// </summary>
        /// <returns></returns>
        public List<Appointment> getAppointments()
        {
            List<Appointment> appointmentList = new List<Appointment>();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM Appointments");
                while (dr.Read())
                {
                    Appointment a = new Appointment();
                    a.getAppointmentID = dr.GetInt32(0);
                    a.getDateTime = dr.GetDateTime(1);
                    a.getStaffID = dr.GetInt32(2);
                    a.getPatientID = dr.GetInt32(3);
                    a.getDescription = dr.GetString(4);
                    appointmentList.Add(a);
                }
            }
            return appointmentList;
        }
        /// <summary>
        /// Updates the status of the given Patient with their given status
        /// </summary>
        /// <param name="patientID">the ID of a Patient</param>
        /// <param name="present">True, False whether or not their are currently present.</param>
        public void PatientStatusUpdate(int patientID, bool present)
        {
            if (con.OpenConnection())
            {
                con.executeQuery("UPDATE patient_details SET CurrentlyPresent = " + present + " WHERE PatientID = " + patientID);
                con.CloseConnection();
            }
        }
        /// <summary>
        /// Executes whatever query is given to it. Does not return any values.
        /// </summary>
        /// <param name="query">The full query you want to send the database.</param>
        public void ExecuteQuery(string query)
        {
            if (con.OpenConnection())
            {
                con.executeQuery(query);
                con.CloseConnection();
            }
        }
        /// <summary>
        /// Get's a given Patients Prescriptions
        /// </summary>
        /// <param name="p_PatientID">The patientsID</param>
        /// <returns></returns>
        public List<Medicine> GetPrescriptions(int p_PatientID)
        {
            if(con.OpenConnection())
            {
                List<Medicine> medicineList = new List<Medicine>();
                DbDataReader dr = con.Select("SELECT MedicineID, StartDate, EndDate FROM MedicineLink WHERE PatientID=" + p_PatientID + ";");
                while(dr.Read())
                {
                    Medicine m = new Medicine();
                    m.getMedicineID = dr.GetInt32(0);
                    m.getStartDate = dr.GetDateTime(1);
                    m.getEndDate = dr.GetDateTime(2);
                    medicineList.Add(m);
                }
                dr.Close();
                dr = con.Select("SELECT MedicineID, MedicineName from Medicine");
                while(dr.Read())
                {
                    foreach(Medicine m in medicineList)
                    {
                        if(m.getMedicineID == dr.GetInt32(0))
                        {
                            m.getMedicineName = dr.GetString(1);
                        }
                    }
                }
                dr.Close();
                con.CloseConnection();
                return medicineList;
            }
            return null;
        }
        /// <summary>
        /// Gets a list of all the medication from the database.
        /// </summary>
        /// <returns></returns>
        public List<Medicine> getAllMedicine()
        {
            List<Medicine> medList = new List<Medicine>();
            if(con.OpenConnection())
            {
                DbDataReader dr;
                dr = con.Select("SELECT * FROM Medicine");
                while(dr.Read())
                {
                    Medicine m = new Medicine();
                    m.getMedicineID = dr.GetInt32(0);
                    m.getMedicineName = dr.GetString(1);
                    medList.Add(m);
                }
                dr.Close();
                con.CloseConnection();
            }
            return medList;
        }
        /// <summary>
        /// gets a list of all the tests that are in the database.
        /// </summary>
        /// <returns></returns>
        public List<Test> getAllTests()
        {
            List<Test> testList = new List<Test>();
            if(con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM Tests");
                while (dr.Read())
                {
                    Test t = new Test();
                    t.getTestID = dr.GetInt32(0);
                    t.getTestName = dr.GetString(1);
                    testList.Add(t);
                }
                dr.Close();
                con.CloseConnection();
                return testList;
            }
            return null;
        }
        /// <summary>
        /// Get's all a list of all the tests a specific patient has taken.
        /// </summary>
        /// <param name="p_PatientID">the ID of the Patient</param>
        /// <returns></returns>
        public List<Test> getPatientTests(int p_PatientID)
        {
            if (con.OpenConnection())
            {
                List<Test> testList = new List<Test>();
                DbDataReader dr = con.Select("SELECT Date, TestID, Result FROM TestLink WHERE PatientID=" + p_PatientID + ";");
                while (dr.Read())
                {
                    Test t = new Test();
                    t.getDate = dr.GetDateTime(0);
                    t.getTestID = dr.GetInt32(1);
                    t.getResult = dr.GetString(2);
                    testList.Add(t);
                }
                dr.Close();
                dr = con.Select("SELECT TestID, TestName from Tests");
                while (dr.Read())
                {
                    foreach(Test t in testList)
                    {
                        if(t.getTestID == dr.GetInt32(0))
                        {
                            t.getTestName = dr.GetString(1);
                        }
                    }
                }
                dr.Close();
                con.CloseConnection();
                return testList ;
            }
            return null;
        }
        /// <summary>
        /// gets a list of notes on a particular patient
        /// </summary>
        /// <param name="p_PatientID">The ID of a patient</param>
        /// <returns></returns>
        public List<PatientNotes> getPatientNotes(int p_PatientID)
        {
            List<PatientNotes> pn = new List<PatientNotes>();
            if(con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM notes WHERE PatientID=" + p_PatientID + ";");

                while(dr.Read())
                {
                    PatientNotes p = new PatientNotes();
                    p.getNoteID = dr.GetInt32(0);
                    p.getNote = dr.GetString(1);
                    p.getDate = dr.GetDateTime(2);
                    p.getPatientID = dr.GetInt32(3);
                    pn.Add(p);
                }
                dr.Close();
                con.CloseConnection();
                return pn;
            }
            return null;
        }
        /// <summary>
        /// Used to get a DATASET of all the members of staff.
        /// </summary>
        /// <returns></returns>
        public DataSet getStaff()
        {
            return con.getDataSet("SELECT StaffID, FirstName, LastName, EmailAddress, StaffType, PhoneNumber FROM Staff");
        }
        public void CreateAppointments(int pID, int dID)
        {
            var createAppointments = "Insert appointments (AppointmentID, AppointmentDate, PatientID, DoctorID) VALUES(patientID, doctorID)";
            con.executeQuery(createAppointments);
        }
    

    }
}