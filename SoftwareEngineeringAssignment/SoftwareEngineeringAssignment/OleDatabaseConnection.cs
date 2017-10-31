using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.Common;
using System.Data;

namespace SoftwareEngineeringAssignment
{
    class OleDbConnection : DbConection
    {
        private Dictionary<string, string> m_properties;
        private OleDbConnection connection;
        public OleDbConnection(Dictionary<string, string> properties)
        {
            m_properties = properties;
            initialize();
        }


        private void initialize()
        {
            try
            {
                StringBuilder sb = new StringBuilder("Provider=");
                sb.Append(m_properties["Provider"]);
                sb.Append(";Data Source=\"");
                sb.Append(m_properties["Database"]);
                sb.Append("\"");
                if (m_properties.ContainsKey("User"))
                {
                    if (m_properties["User"].Length > 0)
                    {
                        sb.Append(";User ID=" + m_properties["User"]);
                        sb.Append("Password=\"");
                        sb.Append(m_properties["Password"]);
                        sb.Append("\"");
                    }
                }
                connection = new OleDbConnection(sb.ToString());
            }
            catch (Exception e)
            {
                // Wrap exception up and throw it on
                throw new DBException("DBException - OleDatabaseConnection::initialize()\n" + e.Message);
            }
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                // Wrap exception up and throw it on
                throw new DBException("DBException - OleDatabaseConnection::OpenConnection()\n" + e.Message);
            }
            return true;
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                // Wrap exception up and throw it on
                throw new DBException("DBException - OleDatabaseConnection::CloseConnection()\n" + e.Message);
            }
            return true;
        }

        public DbDataReader Select(string query)
        {
            DbDataReader reader = null;
            try
            {
                OleDbCommand command = new OleDbCommand(query);
                command.Connection = (OleDbConnection)connection;
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                // Wrap exception up and throw it on
                throw new DBException("DBException - OleDatabaseConnection::RunQuery()\n" + e.Message);
            }
            return reader;
        }

        public DataSet getDataSet(string sqlStatement)
        {

            DataSet dataSet;

            // create the object dataAdapter to manipulate a table from the database StudentDissertations specified by connectionToDB
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlStatement, connection);
            // create the dataset
            dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            //return the dataSet
            return dataSet;
        }
    }
}
