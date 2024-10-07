using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BussinessOperation
{
    public class Customer
    {
        public int CId { get; set; }
        public string CUsername { get; set; } = string.Empty;
        public string CPassword { get; set; } = string.Empty;
        public string CEmail { get; set; } = string.Empty;

        public string CMobile { get; set; } = string.Empty;

        public int Cadd()
        {
            try
            {
                string sql = "INSERT INTO Customers VALUES(" + CId + ",' " + CUsername + "','" + CPassword + "','" + CEmail + "',' " + CMobile + "')";
                return new DB_Operations().executeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public int Cupdate()
        {
            try
            {
                string sql = "UPDATE Customers SET CUsername='" + CUsername + "',CPassword='" + CPassword + "',CEmail='" + CEmail + "',CMobile='" + CMobile + "' WHERE CId=" + CId;
                return new DB_Operations().executeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public int Cdelete()
        {
            try
            {
                string sql = "DELETE FROM Customers WHERE CId=" + CId;
                return new DB_Operations().executeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public DataSet Cfind()
        {
            try
            {
                string sql = "SELECT * FROM Customers WHERE CId=" + CId;
                DataSet ds = new DB_Operations().executeSelectQuery(sql);
                return ds;
            }
            catch
            {
                throw;
            }
        }

        public DataSet CfindAll()
        {
            try
            {
                string sql = "SELECT * FROM Customers";
                return new DB_Operations().executeSelectQuery(sql);
            }
            catch
            {
                throw;
            }
        }
    }
}

