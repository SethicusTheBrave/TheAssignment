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
        static DbConection con = DbFactory.instance();
        static private BusinessMetaLayer m_instance = null;

        private BusinessMetaLayer() { }
        // static just for testing need to change it
        static public BusinessMetaLayer instance()
        {
            if (null == m_instance)
            {
                m_instance = new BusinessMetaLayer();
            }
            return m_instance;
        }

        internal void RegisterPatient(string text1, string text2, string text3, string text4, string text5, string text6)
        {
            throw new NotImplementedException();
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
        //The code used to query the database to compare a given ID and password with the results in the database and return their staffType.
        public string Login(string p_StaffID, string p_Password)
        {
            List<Staff> staffList = new List<Staff>();
            //Will attempt to make a connection with the database.
            if(con.OpenConnection())
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
                            return s.getType;
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

           // return patientList;
        }

        public void RegisterPatients(string PatientFName, string PatientLName, string PatientEmail, string PatientAddress, )
        {

        }

      //  // just a testing
      //static public void RegisterPatients(string medicine)
      //  {

      //      string query = "Insert medicine (MedicineName) VALUES ('SomeMedicine')";

      //      //MySQLCon vv = new MySQLCon();
      //      //vv.Insert(query);
      //      con.Insert(query);
      //  }
    }
}
