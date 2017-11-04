using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringAssignment
{
    class BusinessMetaLayer
    {
        private DbConection con = DbFactory.instance();
        static private BusinessMetaLayer m_instance = null;
        private DisplayMessages message = new DisplayMessages();

        private BusinessMetaLayer() { }

        static public BusinessMetaLayer instance()
        {
            if (null == m_instance)
            {
                m_instance = new BusinessMetaLayer();
            }
            return m_instance;

        }

        // Could just have a set of static helper methods rather than a singleton!
        /*public List<Patient> getPatient()
        {
            List<Patient> patientList = new List<Patient>();

            DbConection con = DbFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT CUST_ID, cust_name, cust_address, cust_city FROM customers;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Patient patient = new Patient();
                    //patient.ID = dr.GetInt32(0);
                    //patient.Name = dr.GetString(1);
                    //patient.Address = dr.GetString(2);
                    //patient.City = dr.GetString(3);
                    // etc.....

                    patientList.Add(patient);
                }

                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }
            return patientList;
        }*/
        //The code used to query the database to compare a given ID and password with the results in the database and return their staffType.
        public Staff Login(string p_StaffID, string p_Password)
        {
            List<Staff> staffList = new List<Staff>();
            //Will attempt to make a connection with the database.
            if (con.OpenConnection())
            {
                //Will select all of the staffID's and Passwords in the Staff table.
                DbDataReader dr = con.Select("SELECT StaffID, Password, StaffType FROM Staff");
                //Will create a Staff object for each entry in the table.
                while (dr.Read())
                {
                    Staff s = new Staff();
                    s.getStaffID = dr.GetString(0);
                    s.getpassword = dr.GetString(1);
                    s.getType = dr.GetString(2);
                    staffList.Add(s);
                }
                //Closes the database reader and the connection to the database.
                dr.Close();
                con.CloseConnection();

                //Compares the password from the textbox with each entry in the database. 
                if (staffList.Count() > 0)
                {
                    foreach (Staff s in staffList)
                    {
                        if (p_StaffID == s.getStaffID && p_Password == s.getpassword)
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
        public List<Patient> patientSearch()
        {
            List<Patient> patientList = new List<Patient>();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT patientID, LastName, FirstName, Address, Postcode, DOB FROM Patient");
                //Will create a Staff object for each entry in the table.
                while (dr.Read())
                {
                    Patient p = new Patient();
                    p.getPatientID = dr.GetString(0);
                    p.getLastName = dr.GetString(1);
                    p.getFirstName = dr.GetString(2);
                    p.getAddress = dr.GetString(3);
                    p.getPostcode = dr.GetString(4);
                    p.getDOB = Convert.ToString(dr.GetDateTime(5));
                    patientList.Add(p);
                }
                con.CloseConnection();
                dr.Close();
                return patientList;
            }
            else
            {
                MessageBox.Show("Database Connection Error!", "An Error has occured when attempting to connect to the database. Please contact your network administrator.");
                return null;
            }
        }
        //// Just some experiments
        //public void RegisterPatients(string firstName, string lastName, DateTime DOB, string religion, string email, string houseNumber, string street,
        //                             string town, string country, string postcode, string phone, string NIN, string tests, string allergies,
        //                             string notes)
        //{
        //    var format = "yyyy-MM-dd";
        //    var queryAddress = "Insert patient_address (HouseNumber, StreetName, Town, Country, PostCode) VALUES ('" + houseNumber + "', '" + street + "', '" + town + "', '" + country + "', '" + postcode + "')";
        //    con.Insert(queryAddress);
        //    DbDataReader getAddressID = con.Select("SELECT AddressID FROM patient_address WHERE HouseNumber = '" + houseNumber + "' AND StreetName = '" + street + "' AND Town = '" + town + "' AND Country = '" + country + "' AND PostCode = '" + postcode + "'");

        //    if (getAddressID.Read())
        //    {

        //        var addressID = getAddressID.GetString(0);
        //        MessageBox.Show("AddressID found" + addressID); con.CloseConnection();
        //        var queryDetails = "Insert patient_details (FirstName, LastName, DateOfBirth, Religion, Email, PhoneNumber, NationalInsuranceNumber, AddressID) VALUES('" + firstName + "', '" + lastName + "', '" + DOB.ToString(format) + "', '" + religion + "', '" + email + "', '" + phone + "', '" + NIN + "', '" + addressID + "')";
        //        con.Insert(queryDetails);
        //        DbDataReader getPatientID = con.Select("SELECT PatientID FROM patient_details WHERE AddressID = '" + addressID + "'");
        //        if (getPatientID.Read())
        //        {
        //            var patientID = getPatientID.GetString(0);

        //            MessageBox.Show("PatientID found" + patientID);
        //            var queryAdditionalInfo = "Insert patient_additional_info (PatientID, Tests, Allergies, Notes) VALUES ('" + patientID + "', '" + tests + "', '" + allergies + "', '" + notes + "')";
        //            con.CloseConnection();
        //            con.Insert(queryAdditionalInfo);
        //        }
        //        else
        //        {
        //            MessageBox.Show("PatientID NOT found");
        //        }

        //    }
        //    else
        //    {
        //        MessageBox.Show("AddressID do not exist");

        //    }
        //}


        //public void patientDob(DateTime dob)
        //{
        //    var format = "yyyy-MM-dd";
        //    var query = "Insert patient_details (DateOfBirth, AddressID) VALUES ('" + dob.ToString(format) + "', '114')";
        //    con.Insert(query);
        //    MessageBox.Show("Date of birth: " + dob);
        //}


        /// <summary>
        ///  tas pats dik su dictionary
        /// </summary>
        /// <param name="patientInfo"></param>
        /// <param name="keys"></param>
        /// //
        //public void zodynas(Dictionary<string, string> patientInfo, string[] keys)
        //{
        //    //var query = "Insert patient_address (HouseNumber, StreetName) VALUES ('"+ patientInfo["firstname"]   + "', '" + patientInfo["lastname"] + "')";
        //    //con.Insert(query);
        //    //patientInfo = null;
        //    //// var arpavyko = 
        //    //if (con.CheckIfQuerySuccessful())
        //    //{
        //    //    MessageBox.Show("its ok");
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("smth wnet wrong");
        //    //}
        //    //foreach (string key in keys)
        //    //{
        //    //   MessageBox.Show("Got value " + patientInfo[key]);
        //    //}

        //    // var format = "yyyy-MM-dd";
        //    var queryAddress = "Insert patient_address (HouseNumber, StreetName, Town, Country, PostCode) VALUES ('" + patientInfo["houseNumber"] + "', '" + patientInfo["street"] + "', '" + patientInfo["town"] + "', '" + patientInfo["country"] + "', '" + patientInfo["postcode"] + "')";
        //    con.Insert(queryAddress);

        //    if (con.CheckIfQuerySuccessful())
        //    {


        //        DbDataReader getAddressID = con.Select("SELECT AddressID FROM patient_address WHERE HouseNumber = '" + patientInfo["houseNumber"] + "' AND StreetName = '" + patientInfo["street"] + "' AND Town = '" + patientInfo["town"] + "' AND Country = '" + patientInfo["country"] + "' AND PostCode = '" + patientInfo["postcode"] + "'");

        //        if (getAddressID.Read())
        //        {

        //            var addressID = getAddressID.GetString(0);
        //            MessageBox.Show("AddressID found" + addressID); con.CloseConnection();
        //            var queryDetails = "Insert patient_details (FirstName, LastName, DateOfBirth, Religion, Email, PhoneNumber, NationalInsuranceNumber, AddressID) VALUES('" + patientInfo["firstName"] + "', '" + patientInfo["lastName"] + "', '" + patientInfo["DOB"] + "', '" + patientInfo["religion"] + "', '" + patientInfo["email"] + "', '" + patientInfo["phone"] + "', '" + patientInfo["NIN"] + "',  '" + addressID + "')";
        //            con.Insert(queryDetails);
        //            if (con.CheckIfQuerySuccessful())
        //            {
        //                DbDataReader getPatientID = con.Select("SELECT PatientID FROM patient_details WHERE AddressID = '" + addressID + "'");
        //                if (getPatientID.Read())
        //                {
        //                    var patientID = getPatientID.GetString(0);

        //                    MessageBox.Show("PatientID found" + patientID);
        //                    var queryAdditionalInfo = "Insert patient_additional_info (PatientID, Tests, Allergies, MedicalHistory, Notes) VALUES ('" + patientID + "', '" + patientInfo["tests"] + "', '" + patientInfo["allergies"] + "', '" + patientInfo["medicalHistory"] + "', '" + patientInfo["notes"] + "')";
        //                    con.CloseConnection();
        //                    con.Insert(queryAdditionalInfo);
        //                    if (con.CheckIfQuerySuccessful())
        //                    {

        //                        message.RegistrationSuccessfull();
        //                    }
        //                    else
        //                    {

        //                        message.RegistrationFailed();
        //                    }
        //                }
        //                else
        //                {
        //                    message.RegistrationFailed();
        //                }
        //            }
        //            else { message.RegistrationFailed(); }
        //        }
        //        else
        //        {
        //            message.RegistrationFailed(); ;

        //        }
        //    }
        //    else { message.RegistrationFailed(); }


        //}

        public void trinti()
        {
            string query = "DELETE FROM patient_address WHERE AddressID='51'";
            con.Delete(query);
        }


    }
}


    

