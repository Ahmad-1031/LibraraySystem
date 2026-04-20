using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraraySystem
{

    //How to Prevent Sql Injection - Used Throughout Project "https://www.acunetix.com/blog/web-security-zone/how-to-prevent-sql-injection-in-csharp/"

    class Database
    {
        public const string connectionString = "Data Source = localhost/orcl; User Id = C##User1; Password = Oracle12345;";

        public static OracleConnection OpenConnection()
        {
            //Open an Oracle DB connection
            OracleConnection conn = new OracleConnection(Database.connectionString.Trim());

            conn.Open();

            return conn;
        }

        public static DataSet ExecuteMultiRowQuery(string query, OracleParameter[] parameters = null)
        {
            //Open a connection to an Oracle database
            OracleConnection conn = OpenConnection();

            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);
            if (parameters != null) {
                cmd.Parameters.AddRange(parameters);
            }

            //Use an OracleDataAdapter as a bridge between the DB and an in-memory
            //data structure (a DataSet in this case)
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Create the DataSet to hold results of the query
            DataSet ds = new DataSet();

            //Populate the DataSet with the results of the query
            //Note that Fill() will use the OracleCommand object to execute query
            da.Fill(ds);

            //Close DB connection
            conn.Close();

            return ds;
        }

        public static OracleDataReader ExecuteSingleRowQuery(string query, OracleParameter[] parameters = null)
        {
                 
            //Open a connection to an Oracle database
            OracleConnection conn = OpenConnection();

            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            //Execute the query and atore the results in an OracleDataReader
            OracleDataReader dr = cmd.ExecuteReader();

            return dr;

        }

        public static void ExecuteNonQuery(string query,OracleParameter[] parameters = null)
        {
            //Open a connection to an Oracle database
            OracleConnection conn = OpenConnection();

            //Formulate the DB request
            OracleCommand cmd = new OracleCommand(query, conn);

            if (parameters != null) {
                cmd.Parameters.AddRange(parameters);
            }


            //Execute the DB non-query
            cmd.ExecuteNonQuery();

            //Close the DB connection
            conn.Close();

        }

        public static object ExecuteScalar(string query, OracleParameter[] parameters) {
        
            OracleConnection conn = OpenConnection();
            OracleCommand cmd = new OracleCommand(query,conn);

            if(parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            return cmd.ExecuteScalar();
        }
    }
}
