using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    class Medicine
    {
        private int m_MedicineID;
        public int getMedicineID { get { return m_MedicineID; } set { m_MedicineID = value; } }
        private string m_MedicineName;
        public string getMedicineName { get { return m_MedicineName; } set { m_MedicineName = value; } }
        private DateTime m_StartDate;
        public DateTime getStartDate { get { return m_StartDate; } set { m_StartDate = value; } }
        private DateTime m_EndDate;
        public DateTime getEndDate { get { return m_EndDate; } set { m_EndDate = value; } }
    }
    class MedicineLink
    {
        private int m_MedicineID;
        public int getMedicineID { get { return m_MedicineID; } set { m_MedicineID = value; } }
        private int m_PatientiD;
        public int getPatientID { get { return m_PatientiD; } set { m_PatientiD = value; } }
    }
}
