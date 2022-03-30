using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CIS_3342_TeamProject.Class;
using System.Data.SqlClient;
using Utilities;
using System.Web.Script.Serialization;  // needed for JSON serializers
using System.IO;                        // needed for Stream and Stream Reader
using System.Net;                      // needed for the Web Request
using TP_API;

namespace CIS_3342_TeamProject
{
    public partial class ServiceForUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            if (txtServiceName.Text == "" || txtHourlyRate.Text == "") 
            {
                lblMessage.Font.Size = 20;
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "If you want to add new services, you need to enter service name, and hourly rate";
                return;
            }
            RetrieveInfo();

        }

        public void RetrieveInfo() 
        {
            Service objservice;
            objservice = new Service();
            objservice.Servicename = txtServiceName.Text;
            objservice.Servicerate = double.Parse(txtHourlyRate.Text);
            int Result = MyMethods.AddingServiceINfoIntoTable(objservice);
        }

        protected void btnDisplayAllServices_Click(object sender, EventArgs e)
        {
            
            lblMessage.Text = "";
            WebRequest request = WebRequest.Create("https://localhost:44326/api/services/displayall");
            WebResponse response = request.GetResponse();

            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            string data = reader.ReadToEnd();
            reader.Close();
            response.Close();

            JavaScriptSerializer js = new JavaScriptSerializer();
            Services[] services = js.Deserialize<Services[]>(data);
            gvServices.DataSource = services;
            gvServices.DataBind();
            
        }

        protected void btnFIndServiceByID_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                lblMessage.Font.Size = 20;
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "If you want to find service, you must enter ID first";
                return;
            }

            int id = 0;
            if(int.TryParse(txtID.Text, out id))
            {
                WebRequest request = WebRequest.Create("https://localhost:44326/api/services/" + id);
                WebResponse response = request.GetResponse();
                Stream theDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(theDataStream);
                String data = reader.ReadToEnd();
                reader.Close();
                response.Close();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Services obj = js.Deserialize<Services>(data);
                if (obj.ServiceName != "")
                {
                    Services[] objser = new Services[1];
                    objser[0] = obj;
                    gvServices.DataSource = objser;
                    gvServices.DataBind();
                    lblMessage.Font.Size = 20;
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "Heres what we find";
                }

                else 
                {
                    lblMessage.Font.Size = 20;
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "No service find ";
                }
            }

        }

        protected void btnDeleteService_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (int.TryParse(txtID.Text, out id))
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                String jsonid = js.Serialize(id);
                try
                {
                    WebRequest request = WebRequest.Create("https://localhost:44326/api/services/DeleteService/" + id);
                    request.Method = "DELETE";
                    request.ContentLength = jsonid.Length;
                    request.ContentType = "application/json";

                    StreamWriter writer = new StreamWriter(request.GetRequestStream());
                    writer.Write(jsonid);
                    writer.Flush();
                    writer.Close();

                    WebResponse response = request.GetResponse();
                    Stream theDataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(theDataStream);
                    String data = reader.ReadToEnd();
                    reader.Close();
                    response.Close();
                    if (data == "1")
                    {
                        lblMessage.Font.Size = 20;
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                        lblMessage.Text = "Service delete successfully";
                    }
                    else
                    {
                        lblMessage.Font.Size = 20;
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                        lblMessage.Text = "Please try again!";
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Font.Size = 20;
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "Error:" + ex.Message;
                }

            }
            else
            {
                lblMessage.Font.Size = 20;
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "If you want to delete service, you must enter ID";
            }
        }

        protected void btnDisplayAllCustomer_Click(object sender, EventArgs e)
        {
            DisplayAllCustomer();
        }

        public void DisplayAllCustomer()
        {
            localhost1.WebService2 pxy = new localhost1.WebService2();
            gvServices.DataSource=  pxy.GetService();
            gvServices.DataBind();
            //DBConnect objDB = new DBConnect();
            //SqlCommand objCommand = new SqlCommand();

            //objCommand.Parameters.Clear();
            //objCommand.CommandType = CommandType.StoredProcedure;
            //objCommand.CommandText = "TP_DisplayAllCustomer";

            //DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand);
            //gvServices.DataSource = ds;
            //gvServices.DataBind();


        }

        protected void btnChangeStatus_Click(object sender, EventArgs e)
        {
            Customers cus = new Customers();
            cus.CustomerID = int.Parse(txtCustomerID.Text);
            cus.Status = txtCustomerstatus.Text;

            JavaScriptSerializer js = new JavaScriptSerializer();
            String jsonCus = js.Serialize(cus);

            try 
            {
                WebRequest request = WebRequest.Create("https://localhost:44326/api/customer");
                request.Method = "PUT";
                request.ContentLength = jsonCus.Length;
                request.ContentType = "application/json";
                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write(jsonCus);
                writer.Flush();
                writer.Close();
                WebResponse response = request.GetResponse();
                Stream theDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(theDataStream);
                String data = reader.ReadToEnd();
                reader.Close();
                response.Close();
                if (data == "1")
                {
                    lblMessage.Font.Size = 20;
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "Update Successfully";
                }
                else 
                {
                    lblMessage.Font.Size = 20;
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "Please try again";
                }
            }
            catch(Exception ex)
            {
                lblMessage.Font.Size = 20;
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Errors: " + ex.Message;
            }
        }

        protected void btnDisplayAllOrder_Click(object sender, EventArgs e)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_DisplayAllOrder";

            DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand);
            gvServices.DataSource = ds;
            gvServices.DataBind();
        }
    }
}