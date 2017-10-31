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

    }
}
