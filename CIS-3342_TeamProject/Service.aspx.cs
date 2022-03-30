using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using CIS_3342_TeamProject.Class;
namespace CIS_3342_TeamProject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        ArrayList arrSelectedService = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                txtTime.Visible = false;
                lblTime.Visible = false;
                gvReport.Visible = false;
                Button1.Visible = false;

            }
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            ShowAllService();
            Button1.Visible = true;
            btnDisplayAll.Visible = false;

        }

        public void ShowAllService() 
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objcommand = new SqlCommand();
            objcommand.CommandType = CommandType.StoredProcedure;
            objcommand.CommandText = "TP_ShowAllService";
            DataSet myDS = objDB.GetDataSetUsingCmdObj(objcommand);

            gvService.DataSource = myDS;
            gvService.DataBind();
            txtTime.Visible = true;
            lblTime.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String errors="";
            try
            {
                DateTime time = DateTime.Parse(txtTime.Text);
                if (DateTime.Compare(time, DateTime.Now) < 0)
                {
                    errors += "Time must be in the future <br/>";
                }
            }
            catch (Exception)
            {
                errors += "Time format is : yyyy-mm-dd hh:mm <br/>";
            }

            if (errors.Length > 0)
            {
                lblError.Text = errors;
                return;
            }
            RetrieveSelectedService();
            
        }

        public void RetrieveSelectedService() 
        {
            String errors = "";
            
            Service objservice;
            objservice = new Service();
            int count = 0;
            int Result = 0;
            try
            {
                DateTime time = DateTime.Parse(txtTime.Text);
                if (DateTime.Compare(time, DateTime.Now) < 0) 
                {
                    errors += "Time must be in the future <br/>";
                }
            }
            catch (Exception) 
            {
                errors += "Time format is : yyyy-mm-dd hh:mm <br/>";
            }

            if (errors.Length > 0) 
            {
                lblError.Text = errors;
                return;
            }
            errors = "";
            for (int row = 0; row < gvService.Rows.Count; row++) 
            {
                CheckBox cbox;
                cbox = (CheckBox)gvService.Rows[row].FindControl("CheckBox1");
                if (cbox.Checked)
                {
                    objservice.User = 1;  //int.Parse(Session["UserID"].ToString());
                    objservice.Serviceid = int.Parse(gvService.Rows[row].Cells[0].Text);
                    objservice.Servicename = gvService.Rows[row].Cells[1].Text;
                    objservice.Servicerate = double.Parse(gvService.Rows[row].Cells[2].Text);
                    objservice.Servicetime = txtTime.Text;
                    arrSelectedService.Add(objservice);
                    count = count + 1;
                    Result = MyMethods.AddingServiceDetails(objservice); 
                }
            }
            if (Result > 0) 
            {
                lblMessage.Font.Size = 30;
                lblMessage.ForeColor = System.Drawing.Color.Black;
                lblMessage.Text = "We have already added this into our schedule, we see you soon";
                gvService.Visible = false;
                ShowReport();
                Button1.Visible = false;
                lblTime.Visible = false;
                txtTime.Visible = false;
            }
            if (count == 0)
            {
                errors += "Make Sure You selected service to process the order";
            }
            lblError.Text = errors;

        }
        public void ShowReport() 
        {
            gvReport.Visible = true;
            gvReport.DataSource = arrSelectedService;
            gvReport.DataBind();
        }

    }
}