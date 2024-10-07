using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AMF
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=LAPTOP-DVE8N1L6\SQLEXPRESS; Initial Catalog=TaskManagerDb; Integrated Security=True;");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;


                con.Open();


                string customerqry = "SELECT CUsername from Customers WHERE CUsername = ' " + username + "'  AND CPassword = '" + password + "'";
                SqlCommand customercmd = new SqlCommand(customerqry, con);
                SqlDataReader customersrd = customercmd.ExecuteReader();


                if (customersrd.Read())
                {
                    // Login successful, redirect to another page
                    Response.Redirect("HOME.aspx");
                }


                else
                {
                    // Invalid credentials
                    lblErrorMsg.Text = "Invalid username or password.";
                    customersrd.Close();
                }



            }
            catch (Exception ex)
            {
                // Handle exceptions
                lblErrorMsg.Text = "Error: " + ex.Message;
            }
            finally
            {
                con.Close(); // Close connection in finally block to ensure it's always closed
            }
        }

        // Dummy method for hashing password (implement your actual hashing logic)
        private string HashPassword(string password)
        {
            // Implement your hashing logic here
            return password; // Dummy implementation
        }
    }
}