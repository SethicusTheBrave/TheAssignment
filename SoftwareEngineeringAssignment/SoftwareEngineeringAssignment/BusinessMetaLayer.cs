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
        public List<Person> getPatient()
        {
            List<Customer> customers = new List<Person>();

            DbConection con = DbFactory.instance();
            if (con.OpenConnection())
            {
                DbDataReader dr = con.Select("SELECT CUST_ID, cust_name, cust_address, cust_city FROM customers;");

                //Read the data and store them in the list
                while (dr.Read())
                {
                    Person patient = new Person();
                    patient.ID = dr.GetInt32(0);
                    patient.Name = dr.GetString(1);
                    patient.Address = dr.GetString(2);
                    patient.City = dr.GetString(3);
                    // etc.....

                    customers.Add(customer);
                }

                //close Data Reader
                dr.Close();
                con.CloseConnection();
            }

            return patients;
        }
    }
}
