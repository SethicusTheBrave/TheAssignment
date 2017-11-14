using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    class PatientNotes
    {
        private int m_noteID;
        public int getNoteID { get { return m_noteID; } set { m_noteID = value; } }
        private DateTime m_date;
        public DateTime getDate { get { return m_date; } set { m_date = value; } }
        private string m_note;
        public string getNote { get { return m_note; } set { m_note = value; } }
        private int m_patientID;
        public int getPatientID { get { return m_patientID; } set { m_patientID = value; } }
    }
}
