using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public bool Login(string p_StaffID, string p_Password)
        {
            List<Staff> staffList = new List<Staff>();
            DbConection con = DbFactory.instance();
            if(con.OpenConnection())
            {
                //LOOKING FOR THE FUCKING COLUMNS OR SOME SHIT!?
                DbDataReader dr = con.Select("SELECT StaffID, Password FROM Staff");
                while(dr.Read())
                {
                    Staff s = new Staff();
                    s.getStaffID = dr.GetString(0);
                    s.getpassword = dr.GetString(1);
                    staffList.Add(s);
                }
                if (staffList.Count() > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {
                MessageBox.Show("Database Connection Error!", "An Error has occured when attempting to connect to the database. Please contact your network administrator.");
                return false;
            }
        }


        SavePacientDetails()
        {

        }


        
    }
}
