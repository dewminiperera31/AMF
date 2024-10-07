using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AMF
{
    public partial class ManageCustomertasks : System.Web.UI.Page
    {
        localhostCustomer.CustomerService cs = new localhostCustomer.CustomerService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            txtId.Text = null;
            txtUsername.Text = null;
            txtPassword.Text = null;
            txtemail.Text = null;
            txtmobile.Text = null;

            txtId.Focus();
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int cid = Convert.ToInt32(txtId.Text);

                if (cs.DeleteCustomer(cid) > 0)
                {
                    lblMessage.Text = "Profile Record Deleted";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error " + ex.Message;
            }
            finally
            {
                clear();
            }


        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int cid = Convert.ToInt32(txtId.Text);
                string cusername = txtUsername.Text;
                string cpassword = txtPassword.Text;
                string cemail = txtemail.Text;
                string cmobile = txtmobile.Text;


                if (cs.UpdateCustomer(cid, cusername, cpassword, cemail, cmobile) > 0)
                {
                    lblMessage.Text = "Profile Record Updated";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error " + ex.Message;
            }
            finally
            {
                clear();
            }
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                int cid = Convert.ToInt32(txtId.Text);
                DataSet ds = cs.FindCustomer(cid);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtId.Text = ds.Tables[0].Rows[0]["CId"].ToString();
                    txtPassword.Text = ds.Tables[0].Rows[0]["CPassword"].ToString();
                    txtUsername.Text = ds.Tables[0].Rows[0]["CUsername"].ToString();
                    txtemail.Text = ds.Tables[0].Rows[0]["CEmail"].ToString();
                    txtmobile.Text = ds.Tables[0].Rows[0]["CMobile"].ToString();

                }
                else
                {
                    lblMessage.Text = "Profile Record not Found ";
                    clear();
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }
    }
}