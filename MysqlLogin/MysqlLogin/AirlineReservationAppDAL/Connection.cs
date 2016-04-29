using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MysqlLogin.AirlineReservationAppDAL
{
    public class Connection
    {
        public SqlConnection con = new SqlConnection(@"Data Source = LENOVO-PC\SQL2014;Initial Catalog=data;Integrated Security = True;");

        public SqlConnection getConnection()
        {
            if (ConnectionState.Closed == con.State)
                con.Open();

            return con;
        }

        public int ExeNonQuery(SqlCommand command)  // Create this function to perform update/insert/delete etc.
        {
            command.Connection = getConnection();
            int rowsAffected = -1;
            rowsAffected = command.ExecuteNonQuery();
            con.Close();
            return rowsAffected;
        }

        //public object Exescalar(SqlCommand command)  // this method will retrieve a single value from DB
        //{
        //    command.Connection = getConnection();
        //    object ob = -1;
        //    ob = command.ExecuteScalar();
        //    con.Close();
        //    return ob;
        //}

        public DataTable ExecuteReader(SqlCommand command) // this method will perform operation select query
        {
            command.Connection = getConnection();
            SqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = command.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
    }
}
