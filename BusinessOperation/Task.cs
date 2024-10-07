using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BussinessOperation
{
    public class Task
    {
        public int TaskID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;


        public int Tadd()
        {
            try
            {
                string sql = "INSERT INTO Tasks VALUES(" + TaskID + ",' " + Title + "','" + Description + "')";
                return new DB_Operations().executeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public int Tupdate()
        {
            try
            {
                string sql = "UPDATE Tasks SET Title='" + Title + "',Description='" + Description + "' WHERE TaskID=" + TaskID;
                return new DB_Operations().executeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public int Tdelete()
        {
            try
            {
                string sql = "DELETE FROM Tasks WHERE TaskID=" + TaskID;
                return new DB_Operations().executeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public DataSet Tfind()
        {
            try
            {
                string sql = "SELECT * FROM Tasks WHERE TaskID=" + TaskID;
                DataSet ds = new DB_Operations().executeSelectQuery(sql);
                return ds;
            }
            catch
            {
                throw;
            }
        }

        public DataSet TfindAll()
        {
            try
            {
                string sql = "SELECT * FROM Tasks";
                return new DB_Operations().executeSelectQuery(sql);
            }
            catch
            {
                throw;
            }
        }
    }
}