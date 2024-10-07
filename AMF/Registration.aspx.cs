using System;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Web.UI;


namespace AMF
{
    public partial class Registeration : System.Web.UI.Page
    {
        localhostCustomer.CustomerService cs = new localhostCustomer.CustomerService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieving values from text boxes
                if (!int.TryParse(txtCId.Text, out int cid))
                {
                    lblErrorMsg.Text = "Invalid ID. Please enter a valid number.";
                    return;
                }


                string cusername = txtUsername.Text;
                string cpassword = txtPassword.Text;
                string cemail = txtEmail.Text;
                string cmobile = txtMobile.Text;

                if (string.IsNullOrEmpty(cusername) || string.IsNullOrEmpty(cpassword) ||
                      string.IsNullOrEmpty(cemail) || string.IsNullOrEmpty(cmobile))
                {
                    lblErrorMsg.Text = "All required fields must be filled out.";
                    return;
                }

                // Hash the password before storing it
                string passwordHash = HashPassword(cpassword);

                // Register the partner using the retrieved values
                if (cs.AddCustomer(cid, cusername, passwordHash, cemail, cmobile) > 0)
                {
                    Response.Redirect("login.aspx");
                }

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Error number for primary key violation
                {
                    lblErrorMsg.Text = "A partner with the same ID already exists. Please try again.";
                    // Optionally, you can log this error or handle it as needed
                }
                else
                {
                    lblDebugInfo.Text = "SQL Error: " + ex.Message;
                }
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = "Error: " + ex.Message;
            }
            finally
            {
                ClearFields(); // Assuming ClearFields() is a method that clears the input fields
            }
        }

        // Dummy method for hashing password (implement your actual hashing logic)
        private string HashPassword(string password)
        {
            // Implement your hashing logic here
            return password; // This should return the hashed password
        }

        // Dummy method to get a new partner ID (implement your actual logic)
        private int GetNewPartnerId()
        {
            // Implement your logic to get a new partner ID here
            // This could be a database call to get the next available ID, for example
            return 1; // This should return a unique partner ID
        }

        // Method to clear input fields
        private void ClearFields()
        {
            txtCId.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";


        }
    }
}