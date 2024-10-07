using System.Web.Services.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Services;
using BussinessOperation;

namespace AMF
{
    /// <summary>
    /// Summary description for TaskService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TaskService : System.Web.Services.WebService
    {

        [WebMethod]
        public int addTask(int TaskID, string Title, string Description)
        {
            try
            {
                Task eve = new Task
                {
                    TaskID = TaskID,
                    Title = Title,
                    Description = Description


                };
                return eve.Tadd();
            }
            catch (Exception ex)
            {
                throw new SoapException("Error adding Task: " + ex.Message, SoapException.ServerFaultCode, ex);
            }
        }

        [WebMethod]
        public DataSet findTask(int TaskID)
        {
            try
            {
                Task eve = new Task { TaskID = TaskID };
                return eve.Tfind();
            }
            catch (Exception ex)
            {
                throw new SoapException("Error finding Task: " + ex.Message, SoapException.ServerFaultCode, ex);
            }
        }

        [WebMethod]
        public int updateTask(int TaskID, string Title, string Description)
        {
            try
            {
                Task eve = new Task
                {
                    TaskID = TaskID,
                    Title = Title,
                    Description = Description
                };
                return eve.Tupdate();
            }
            catch (Exception ex)
            {
                throw new SoapException("Error updating Task: " + ex.Message, SoapException.ServerFaultCode, ex);
            }
        }

        [WebMethod]
        public int deleteTask(int TaskID)
        {
            try
            {
                Task eve = new Task { TaskID = TaskID };
                return eve.Tdelete();
            }
            catch (Exception ex)
            {
                throw new SoapException("Error deleting Task: " + ex.Message, SoapException.ServerFaultCode, ex);
            }
        }

        [WebMethod]
        public DataSet viewAllTask()
        {
            try
            {
                return new Task().TfindAll();
            }
            catch (Exception ex)
            {
                throw new SoapException("Error viewing all Tasks: " + ex.Message, SoapException.ServerFaultCode, ex);
            }
        }
    }
}
