using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    /// <summary>
    /// A property based class for storing all the details required for an appointment.
    /// </summary>
    public class Appointment
    {
        int m_AppointmentID;
        public int getAppointmentID { get { return m_AppointmentID; } set { m_AppointmentID = value; } }
        DateTime m_dt;
        public DateTime getDateTime { get { return m_dt; } set { m_dt = value; } }
        int m_patientID;
        public int getPatientID { get { return m_patientID; } set { m_patientID = value; } }
        int m_staffID;
        public int getStaffID { get { return m_staffID; } set { m_staffID = value; } }
        string m_description;
        public string getDescription { get { return m_description; } set { m_description = value; } }
    }
}
