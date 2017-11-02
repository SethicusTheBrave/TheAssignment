using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    class BusinessMetaLayer
    {
        static private BusinessMetaLayer m_instance = null;

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
        public List<Patient> getPatient()
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

            public void RegisterPatient(string firstName, string lastName, string email, string address, string postcode, string phoneNumber) {

             string query = "Insert patient (PatientID, LastName, FirstName, Address, Postcode,DoctorID) VALUES ('firstName', 'lastName', 'email', 'address', 'postcode', 'phoneNumber')";
                MySQLCon vv = new MySQLCon();
                vv.Insert(query);
                

            }

            return patientList;
        }
    }
}
