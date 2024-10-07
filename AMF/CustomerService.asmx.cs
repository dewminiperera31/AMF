using System;
using System.Data;
using System.Web.Services;
using System.Web.Services.Protocols;
using BussinessOperation; // Ensure this namespace is correct and accessible

namespace AMF
{
    /// <summary>
    /// Summary description for CustomerService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CustomerService : System.Web.Services.WebService
    {

        // Method to add a new customer
        [WebMethod]
        public int AddCustomer(int cid, string cusername, string cpassword, string cemail, string cmobile)
        {
            try
            {
                var customer = new Customer
                {
                    CId = cid,
                    CUsername = cusername,
                    CPassword = cpassword,
                    CEmail = cemail,
                    CMobile = cmobile
                };
                return customer.Cadd(); // Assuming this method returns an integer indicating success or failure
            }
            catch (Exception ex)
            {
                throw new SoapException("Error adding Customer: " + ex.Message, SoapException.ServerFaultCode, ex);
            }
        }

        // Method to find a customer by ID
        [WebMethod]
        public DataSet FindCustomer(int cid)
        {
            try
            {
                var customer = new Customer { CId = cid };
                return customer.Cfind(); // Assuming this method returns a DataSet with the customer's data
            }
            catch (Exception ex)
            {
                throw new SoapException("Error finding Customer: " + ex.Message, SoapException.ServerFaultCode, ex);
            }
        }

        // Method to update an existing customer's details
        [WebMethod]
        public int UpdateCustomer(int cid, string cusername, string cpassword, string cemail, string cmobile)
        {
            try
            {
                var customer = new Customer
                {
                    CId = cid,
                    CUsername = cusername,
                    CPassword = cpassword,
                    CEmail = cemail,
                    CMobile = cmobile
                };
                return customer.Cupdate(); // Assuming this method returns an integer indicating success or failure
            }
            catch (Exception ex)
            {
                throw new SoapException("Error updating Customer: " + ex.Message, SoapException.ServerFaultCode, ex);
            }
        }

        // Method to delete a customer by ID
        [WebMethod]
        public int DeleteCustomer(int cid)
        {
            try
            {
                var customer = new Customer { CId = cid };
                return customer.Cdelete(); // Assuming this method returns an integer indicating success or failure
            }
            catch (Exception ex)
            {
                throw new SoapException("Error deleting Customer: " + ex.Message, SoapException.ServerFaultCode, ex);
            }
        }

        // Method to view all customers
        [WebMethod]
        public DataSet ViewAllCustomers()
        {
            try
            {
                return new Customer().CfindAll(); // Assuming this method returns a DataSet with all customers
            }
            catch (Exception ex)
            {
                throw new SoapException("Error viewing all Customers: " + ex.Message, SoapException.ServerFaultCode, ex);
            }
        }
    }
}
