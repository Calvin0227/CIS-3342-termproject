using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CIS_3342_TeamProject.Class;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;


namespace CIS_3342_TeamProject
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.Cookies["LoginDetail"] != null )
            {
                message.Visible = true;
                HttpCookie cookie = Request.Cookies["LoginDetail"];
                message.InnerText = "We have your record, heres your username:  " + cookie.Values["Username"].ToString();
                message2.InnerText = "Please Check Your email, we have sent you the reset link";
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtlog.Text == "admin" || txtPassword.Text =="AdminLogin") 
            {
                Response.Redirect("AddingServicePageForAdmin.aspx");
            }
            else { 
            error.Visible = false;
            warning.Visible = false;
            if (string.IsNullOrEmpty(txtlog.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                warning.Visible = true;
            }
            else
            {
                List<Customers> account = new List<Customers>();

                account = MyMethods.getAccount(txtlog.Text, txtPassword.Text);

                if (account.Count == 1)
                {
                    foreach(var cust in account)
                    {
                        Session["CustomerID"] = cust.CustomerID.ToString();
                        Session["email"] = cust.Email.ToString();                        
                    }

                    HttpCookie myCookie = new HttpCookie("LoginDetail");
                    myCookie.Values["Username"] = txtlog.Text;
                    myCookie.Values["Password"] = txtPassword.Text;
                    myCookie.Expires = new DateTime(2022, 12, 1);
                    Response.Cookies.Add(myCookie);

                    Response.Redirect("MainPage.aspx");

                }
                else
                {
                    error.Visible = true;
                    warning.Visible = false;
                }

            }
            }

        }

      

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountSignUp.aspx");
        }
    }
}