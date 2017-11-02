using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    abstract class Person
    {
         string m_firstName;
         string m_lastName;
         string m_email;
         string m_phoneNumber;
         string m_address;
    }
    class Patient : Person
    {

    }
    class Staff : Person
    {
        private string m_staffID;
        public string getStaffID {get{ return m_staffID; }set { m_staffID = value; } }
        private string m_password;
        public string getpassword { get { return m_password; } set { m_password = value; } }
        private string m_staffType;
        public string getType { get { return m_staffType; } set { m_staffType = value; } }
    }
}
