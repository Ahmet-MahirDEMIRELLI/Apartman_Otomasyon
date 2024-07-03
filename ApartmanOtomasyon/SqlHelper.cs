using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ApartmanOtomasyon
{
    internal class SqlHelper
    {
        private string ConnectionString { get; set; }
        public SqlConnection Connection { get; set; }
        public SqlHelper()
        {
            ConnectionString = @"Data Source=AMD;Initial Catalog=Apartman;Integrated Security=True";
            Connection = new SqlConnection(ConnectionString);
        }

        public void ExecuteProcedure(string procName, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = procName;
            cmd.Parameters.AddRange(parameters);
            cmd.Connection = Connection;
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        public DataTable GetTable(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, ConnectionString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
