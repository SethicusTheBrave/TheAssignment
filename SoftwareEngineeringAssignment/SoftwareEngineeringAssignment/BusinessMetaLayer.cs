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
        public string encrypt(string toBeEncrypted)
        {
            AES.Key = md5.ComputeHash(utf8.GetBytes("SUPERsecureKEY1"));
            AES.Mode = CipherMode.ECB;
            AES.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = AES.CreateEncryptor();
            return (BitConverter.ToString(trans.TransformFinalBlock(utf8.GetBytes(toBeEncrypted), 0, utf8.GetBytes(toBeEncrypted).Length)));
        }
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
        //This method wwill get all of the patients in the database and return them as a list of patients.
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
        //this method will get all the appointments from the database and return them as a list of appointments
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
        //Simply changes the value in the database to either here or not here.
        public void PatientStatusUpdate(int patientID, bool present)
        {
            if (con.OpenConnection())
            {
                con.executeQuery("UPDATE patient_details SET CurrentlyPresent = " + present + " WHERE PatientID = " + patientID);
                con.CloseConnection();
            }
        }
        //Will execute the query given to it. Mainly used for INSERT queries into the database. This method will not return any values.
        public void ExecuteQuery(string query)
        {
            if (con.OpenConnection())
            {
                con.executeQuery(query);
                con.CloseConnection();
            }
        }
        //Used to get all of the prescriptions that have been given to a specific patient and return them as a list.
        public List<Medicine> GetPrescriptions(int p_PatientID)
        {
            if (con.OpenConnection())
            {
                int i = 0;
                List<Medicine> medicineList = new List<Medicine>();
                List<Medicine> FinalList = new List<Medicine>();
                List<MedicineLink> medicineLinkList = new List<MedicineLink>();
                DbDataReader dr = con.Select("SELECT StartDate, EndDate, MedicineID, PatientID FROM MedicineLink");
                while (dr.Read())
                {
                    MedicineLink ml = new MedicineLink();
                    ml.getMedicineID = dr.GetInt32(2);
                    ml.getPatientID = dr.GetInt32(3);
                    medicineLinkList.Add(ml);
                    Medicine m = new Medicine();
                    m.getStartDate = dr.GetDateTime(0);
                    m.getEndDate = dr.GetDateTime(1);
                    medicineList.Add(m);
                }
                dr.Close();
                foreach (MedicineLink m in medicineLinkList)
                {
                    if (m.getPatientID != p_PatientID)
                    {
                        medicineLinkList.RemoveAt(i);
                    }
                    i++;
                }
                i = 0;
                dr = con.Select("SELECT MedicineID, MedicineName FROM medicine");
                while (dr.Read())
                {
                    if (medicineList.Count() >= i)
                    {
                        medicineList.ElementAt(i).getMedicineID = dr.GetInt32(0);
                        medicineList.ElementAt(i).getMedicineName = dr.GetString(1);
                        i++;
                    }
                }
                foreach (MedicineLink ml in medicineLinkList)
                {
                    foreach (Medicine m in medicineList)
                    {
                        if (ml.getMedicineID == m.getMedicineID)
                        {
                            FinalList.Add(m);
                        }
                    }
                }
                dr.Close();
                con.CloseConnection();
                return FinalList;
            }
            else
                return null;
        }
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
        //Used to get all of the tests a patient has done and return them as a list.
        public List<Test> getPatientTests(int p_PatientID)
        {
            if (con.OpenConnection())
            {
                int i = 0;
                List<Test> testList = new List<Test>();
                List<Test> FinalList = new List<Test>();
                List<TestLink> testLinkList = new List<TestLink>();
                DbDataReader dr = con.Select("SELECT Date, TestID, PatientID FROM TestLink");
                while (dr.Read())
                {
                    TestLink tl = new TestLink();
                    tl.getTestID = dr.GetInt32(1);
                    tl.getPatientID = dr.GetInt32(2);
                    testLinkList.Add(tl);
                    Test t = new Test();
                    t.getDate = dr.GetDateTime(0);
                    testList.Add(t);
                }
                dr.Close();
                foreach (TestLink t in testLinkList)
                {
                    if (t.getPatientID != p_PatientID)
                    {
                        testLinkList.RemoveAt(i);
                    }
                    i++;
                }
                i = 0;
                dr = con.Select("SELECT TestID, TestName, Result FROM Tests");
                while (dr.Read())
                {
                    if (testList.Count() >= i)
                    {
                        testList.ElementAt(i).getTestID = dr.GetInt32(0);
                        testList.ElementAt(i).getTestName = dr.GetString(1);
                        testList.ElementAt(i).getResult = dr.GetString(2);
                        i++;
                    }
                }
                foreach (TestLink tl in testLinkList)
                {
                    foreach (Test t in testList)
                    {
                        if (tl.getTestID == t.getTestID)
                        {
                            FinalList.Add(t);
                        }
                    }
                }
                dr.Close();
                con.CloseConnection();
                return FinalList;
            }
            else
                return null;
        }
        //Used to get all the notes a doctor has made on a patient and return it as a list
        public List<PatientNotes> getPatientNotes(int p_PatientID)
        {
            List<PatientNotes> pn = new List<PatientNotes>();
            if(con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT * FROM notes");

                while(dr.Read())
                {
                    PatientNotes p = new PatientNotes();
                    p.getNoteID = dr.GetInt32(0);
                    p.getNote = dr.GetString(1);
                    p.getDate = dr.GetDateTime(2);
                    p.getPatientID = dr.GetInt32(3);
                    pn.Add(p);
                }
                int i = 0;
                foreach(PatientNotes p in pn)
                {
                    if(p.getPatientID != p_PatientID)
                    {
                        pn.RemoveAt(i);
                    }
                    i++;
                }
                dr.Close();
                con.CloseConnection();
                return pn;
            }
            return null;
        }
        //used to get a DATASET (to be displayed in a table) of all of the staff members currently in the database.
        public DataSet getStaff()
        {
            return con.getDataSet("SELECT StaffID, FirstName, LastName, EmailAddress, StaffType, PhoneNumber FROM Staff");
        }
       
        // Patient registration not finished but working. will be improved.
        public void RegisterPatients(Dictionary<string, string> patientInfo, string[] keys)
        {
            var queryAddress = "Insert patient_address (HouseNumber, StreetName, Town, Country, PostCode) VALUES ('" + patientInfo["houseNumber"] + "', '" + patientInfo["street"] + "', '" + patientInfo["town"] + "', '" + patientInfo["country"] + "', '" + patientInfo["postcode"] + "')";
            con.executeQuery(queryAddress);

            DbDataReader getAddressID = con.Select("SELECT AddressID FROM patient_address WHERE HouseNumber = '" + patientInfo["houseNumber"] + "' AND StreetName = '" + patientInfo["street"] + "' AND Town = '" + patientInfo["town"] + "' AND Country = '" + patientInfo["country"] + "' AND PostCode = '" + patientInfo["postcode"] + "'");

            if (getAddressID.Read())
            {
           
                var addressID = getAddressID.GetString(0);
                MessageBox.Show("AddressID found" + addressID); con.CloseConnection();
                var queryDetails = "Insert patient_details (FirstName, LastName, DateOfBirth, Religion, Email, PhoneNumber, AddressID) VALUES('" + patientInfo["firstName"] + "', '" + patientInfo["lastName"] + "', '" + patientInfo["DOB"] + "', '" + patientInfo["religion"] + "', '" + patientInfo["email"] + "', '" + patientInfo["phone"] + "',  '" + addressID + "')";
                con.executeQuery(queryDetails);

                DbDataReader getPatientID = con.Select("SELECT PatientID FROM patient_details WHERE AddressID = '" + addressID + "'");
                if (getPatientID.Read())
                {
                    var patientID = getPatientID.GetString(0);

                    MessageBox.Show("PatientID found" + patientID);
                    var queryAdditionalInfo = "Insert patient_additional_info (PatientID, Tests, Allergies, MedicalHistory, Notes) VALUES ('" + patientID + "', '" + patientInfo["tests"] + "', '" + patientInfo["allergies"] + "', '" + patientInfo["medicalHistory"] + "', '" + patientInfo["notes"] + "')";
                    con.CloseConnection();
                    con.executeQuery(queryAdditionalInfo);
                    if (con.CheckIfQuerySuccessful())
                    {

                        MessageBox.Show("The patient was registered successfully!!!");
                    }
                    else
                    {

                         MessageBox.Show("Registration failed! Please make sure you are providing correct data and try again.Contact administrator if needed.");
                    }
                }
                    else
                    {
                        string deleteDetails = "DELETE FROM patient_address WHERE AddressID = '" + addressID + "'";
                        con.executeQuery(deleteDetails);
                        MessageBox.Show("Registration failed! Please make sure you are providing correct data and try again.Contact administrator if needed.");
                    }
            }
            else
            {
                MessageBox.Show("Registration failed! Please make sure you are providing correct data and try again.Contact administrator if needed.");
                string deleteAddress = "DELETE FROM patient_address WHERE HouseNumber = '" + patientInfo["houseNumber"] + "' AND StreetName = '"+ patientInfo["street"] + "', Town = '"+ patientInfo["town"] + "' , Country = '" + patientInfo["country"] +"',  PostCode = '"+ patientInfo["postcode"] + "'";
                con.executeQuery(deleteAddress);
            }
        }
        public void CreateAppointments(int pID, int dID)
        {
            var createAppointments = "Insert appointments (AppointmentID, AppointmentDate, PatientID, DoctorID) VALUES(patientID, doctorID)";
            con.executeQuery(createAppointments);
        }
    

    }
}


    

