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
        public List<Patient> patientList()
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





        // Patient registration not finished but working. will be improved.
        public void RegisterPatients(Dictionary<string, string> patientInfo, string[] keys)
        {
            var queryAddress = "Insert patient_address (HouseNumber, StreetName, Town, Country, PostCode) VALUES ('" + patientInfo["houseNumber"] + "', '" + patientInfo["street"] + "', '" + patientInfo["town"] + "', '" + patientInfo["country"] + "', '" + patientInfo["postcode"] + "')";
            con.Insert(queryAddress);

            if (con.CheckIfQuerySuccessful())
            {


                DbDataReader getAddressID = con.Select("SELECT AddressID FROM patient_address WHERE HouseNumber = '" + patientInfo["houseNumber"] + "' AND StreetName = '" + patientInfo["street"] + "' AND Town = '" + patientInfo["town"] + "' AND Country = '" + patientInfo["country"] + "' AND PostCode = '" + patientInfo["postcode"] + "'");

                if (getAddressID.Read())
                {

                    var addressID = getAddressID.GetString(0);
                    MessageBox.Show("AddressID found" + addressID); con.CloseConnection();
                    var queryDetails = "Insert patient_details (FirstName, LastName, DateOfBirth, Religion, Email, PhoneNumber, NationalInsuranceNumber, AddressID) VALUES('" + patientInfo["firstName"] + "', '" + patientInfo["lastName"] + "', '" + patientInfo["DOB"] + "', '" + patientInfo["religion"] + "', '" + patientInfo["email"] + "', '" + patientInfo["phone"] + "', '" + patientInfo["NIN"] + "',  '" + addressID + "')";
                    con.Insert(queryDetails);
                    if (con.CheckIfQuerySuccessful())
                    {
                        DbDataReader getPatientID = con.Select("SELECT PatientID FROM patient_details WHERE AddressID = '" + addressID + "'");
                        if (getPatientID.Read())
                        {
                            var patientID = getPatientID.GetString(0);

                            MessageBox.Show("PatientID found" + patientID);
                            var queryAdditionalInfo = "Insert patient_additional_info (PatientID, Tests, Allergies, MedicalHistory, Notes) VALUES ('" + patientID + "', '" + patientInfo["tests"] + "', '" + patientInfo["allergies"] + "', '" + patientInfo["medicalHistory"] + "', '" + patientInfo["notes"] + "')";
                            con.CloseConnection();
                            con.Insert(queryAdditionalInfo);
                            if (con.CheckIfQuerySuccessful())
                            {

                                message.RegistrationSuccessfull();
                            }
                            else
                            {

                                message.RegistrationFailed();
                            }
                        }
                        else
                        {
                            message.RegistrationFailed();
                        }
                    }
                    else { message.RegistrationFailed(); }
                }
                else
                {
                    message.RegistrationFailed(); ;

                }
            }
            else { message.RegistrationFailed(); }







        }
    }
}


    

