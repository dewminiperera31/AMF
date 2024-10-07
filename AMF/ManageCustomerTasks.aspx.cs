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
    public partial class ManageCustomerTasks : System.Web.UI.Page
    {
        localhostTask.TaskService cs = new localhostTask.TaskService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            txtId.Text = null;
            txtTitle.Text = null;
            txtDescription.Text = null;


            txtId.Focus();
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate TaskID input
                if (string.IsNullOrEmpty(txtId.Text) || !int.TryParse(txtId.Text, out int TaskID))
                {
                    lblMessage.Text = "Please enter a valid Task ID.";
                    return;
                }

                string Title = txtTitle.Text;
                string Description = txtDescription.Text;

                // Check if the addTask method returns a positive result indicating success
                int result = cs.addTask(TaskID, Title, Description);
                if (result > 0)
                {
                    lblMessage.Text = "Task Record Inserted";
                }
                else
                {
                    lblMessage.Text = "Task insertion failed, please try again.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
            finally
            {
                clear();
            }
        }




        protected void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int TaskID = Convert.ToInt32(txtId.Text);

                if (cs.deleteTask(TaskID) > 0)
                {
                    lblMessage.Text = "Task Record Deleted";
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
                int TaskID = Convert.ToInt32(txtId.Text);
                string Title = txtTitle.Text;
                string Description = txtDescription.Text;


                if (cs.updateTask(TaskID, Title, Description) > 0)
                {
                    lblMessage.Text = "Task Record Updated";
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
                int TaskID = Convert.ToInt32(txtId.Text);
                DataSet ds = cs.findTask(TaskID);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtId.Text = ds.Tables[0].Rows[0]["TaskId"].ToString();
                    txtTitle.Text = ds.Tables[0].Rows[0]["Title"].ToString();
                    txtDescription.Text = ds.Tables[0].Rows[0]["Description"].ToString();


                }
                else
                {
                    lblMessage.Text = "Task Record not Found ";
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