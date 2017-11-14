using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public abstract class Person
    {
        string m_firstName;
        public string getFirstName{ get { return m_firstName; } set { m_firstName = value; } }
        string m_lastName;
        public string getLastName { get { return m_lastName; } set { m_lastName = value; } }
        string m_email;
        public string getEmail { get { return m_email; } set { m_email = value; } }
        string m_phoneNumber;
        public string getPhoneNumber { get { return m_phoneNumber; } set { m_phoneNumber = value; } }
        string m_address;
        public string getAddress { get { return m_address; } set { m_address = value; } }
        string m_postcode;
        public string getPostcode { get { return m_postcode; } set { m_postcode = value; } }
        string m_country;
        public string getCountry { get { return m_country; } set { m_country = value; } }
        DateTime m_DOB;
        public DateTime getDOB { get { return m_DOB; } set { m_DOB = value; } }
    }
    public class Patient : Person
    {
        int m_patientID;
        public int getPatientID { get { return m_patientID; } set { m_patientID = value; } }
        bool m_present;
        public bool getPresent { get { return m_present; } set { m_present = value; } }
        string m_medicalHistory;
        public string getMedicalHistory { get { return m_medicalHistory; } set { m_medicalHistory = value; } }
    }
    public class Staff : Person
    {
        private int m_staffID;
        public int getStaffID {get{ return m_staffID; }set { m_staffID = value; } }
        private string m_password;
        public string getpassword { get { return m_password; } set { m_password = value; } }
        private string m_staffType;
        public string getType { get { return m_staffType; } set { m_staffType = value; } }
    }
}
