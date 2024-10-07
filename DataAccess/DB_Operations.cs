using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DB_Operations
    {
        public int TaskID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        private SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DVE8N1L6\SQLEXPRESS; Initial Catalog=TaskManagerDb; Integrated Security=True;");


        public int CId { get; set; }
        public string CUsername { get; set; } = string.Empty;
        public string CPassword { get; set; } = string.Empty;
        public string CEmail { get; set; } = string.Empty;
        public string CMobile { get; set; } = string.Empty;


        public int executeQuery(string sql)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                return com.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public DataSet executeSelectQuery(string sql)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public int ExecuteParameterizedQuery(string sql, SqlParameter[] parameters)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddRange(parameters);
                return com.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public object ExecuteScalarQuery(string sql, SqlParameter[] parameters)
        {
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddRange(parameters);
                return com.ExecuteScalar();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public int executeScalarQuery(string sql, SqlParameter[] parameters)
        {

            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddRange(parameters);
                con.Open();
                return (int)cmd.ExecuteScalar();
            }

        }
    }
}

