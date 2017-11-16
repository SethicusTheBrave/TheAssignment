using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    class Test
    {
        private DateTime m_Date;
        public DateTime getDate { get { return m_Date; } set { m_Date = value; } }
        private int m_TestID;
        public int getTestID { get { return m_TestID; } set { m_TestID = value; } }
        private string m_TestName;
        public string getTestName { get { return m_TestName; } set { m_TestName = value; } }
        private string m_Result;
        public string getResult { get { return m_Result; } set { m_Result = value; } }
    }
    class TestLink
    {
        private DateTime m_Date;
        public DateTime getDate { get { return m_Date; } set { m_Date = value; } }
        private int m_TestID;
        public int getTestID { get { return m_TestID; } set { m_TestID = value; } }
        private int m_PatientID;
        public int getPatientID { get { return m_PatientID; } set { m_PatientID = value; } }
    }
}
