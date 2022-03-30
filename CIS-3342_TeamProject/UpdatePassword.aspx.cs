using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using CIS_3342_TeamProject.Class;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
namespace CIS_3342_TeamProject
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNewPassword.Visible = false;
            txtNewPassword.Visible = false;
            lblNewPassword1.Visible = false;
            txtNewPassword1.Visible = false;
            btnChangepassword.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String Email = txtEmail.Text;
            String Q1 = txtQ1Answer.Text;
            String Q2 = txtQ2Answer.Text;
            String Q3 = txtQ3Answer.Text;
            String Result = checkinput(Email,Q1,Q2,Q3);
            if (Result == "")
            {
                int result = 0;
                SignUpInfoClass objinfo = new SignUpInfoClass();
                objinfo.Email = Email;
                objinfo.Answer1 = Q1;
                objinfo.Answer2 = Q2;
                objinfo.Answer3 = Q3;
                DataSet ds = MyMethods.CheckAccount(objinfo);
                result = ds.Tables[0].Rows.Count;
                if (result == 0)
                {
                    lblDisplay.Font.Size = 30;
                    lblDisplay.ForeColor = System.Drawing.Color.Red;
                    lblDisplay.Text = "Sorry We Dont have your info, please Sign up again";
                }
                else 
                {
                    Session["Email"] = txtEmail.Text;
                     lblDisplay.Font.Size = 30;
                    lblDisplay.ForeColor = System.Drawing.Color.Red;
                    lblDisplay.Text = "Wuhoo, Now You can reset your password";
                    lblEmail.Visible = false;
                    txtEmail.Visible = false;
                    lblQ1.Visible = false;
                    lblNewPassword1.Visible = true;
                    txtNewPassword1.Visible = true;
                    txtQ1Answer.Visible = false;
                    btnChangepassword.Visible = true;
                    lblQ2.Visible = false;
                    txtQ2Answer.Visible = false;
                    lblQ3.Visible = false;
                    txtQ3Answer.Visible = false;
                    btnCheckAccont.Visible = false;
                    lblNewPassword.Visible = true;
                    txtNewPassword.Visible = true;


                }
            }
            else 
            {
                lblDisplay.Font.Size = 30;
                lblDisplay.ForeColor = System.Drawing.Color.Red;
                lblDisplay.Text = Result;
            }
        }

        public String checkinput(String Email, String Q1, String Q2, String Q3) 
        {
            String Error = "";
            String email = Email;
            String q1 = Q1;
            String q2 = Q2;
            String q3 = Q3;
            if (email == "" || q1 == "" || q2 == "" || q3 == "")
            {
                Error = "Please Make Sure Fill Out All The Info";

            }

            return Error;
        }

        protected void btnChangepassword_Click(object sender, EventArgs e)
        {
            int check = CheckPasswordSame();
            if (check == 1)
            {
                ChangePassword();
            }
            else if (check == -1) 
            {
                lblDisplay.Font.Size = 15;
                lblDisplay.ForeColor = System.Drawing.Color.Red;
                lblDisplay.Text = "Please Make Sure You Enter The Same Password";
            }
        }
        public int CheckPasswordSame() 
        {
            String password1 = txtNewPassword.Text;
            String confirmpass = txtNewPassword1.Text;
            if (password1 == confirmpass)
            {
                return 1;
            }
            else 
            {
                return -1;
            }
        }

        public void ChangePassword() 
        {
            SignUpInfoClass objinfo = new SignUpInfoClass();
            String Email = Session["Email"].ToString();
            objinfo.Email = Email;
            objinfo.Password = txtNewPassword.Text;
            
            JavaScriptSerializer js = new JavaScriptSerializer();
            String jsonPassword = js.Serialize(objinfo);

            try
            {
                // Setup an HTTP POST Web Request and get the HTTP Web Response from the server.
                WebRequest request = WebRequest.Create("https://localhost:44326/api/Customer/updatepassword");
                request.Method = "POST";
                request.ContentLength = jsonPassword.Length;
                request.ContentType = "application/json";

                // Write the JSON data to the Web Request
                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write(jsonPassword);
                writer.Flush();
                writer.Close();

                // Read the data from the Web Response, which requires working with streams.
                WebResponse response = request.GetResponse();
                Stream theDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(theDataStream);
                String data = reader.ReadToEnd();
                reader.Close();
                response.Close();

                if (data == "1")
                {
                    lblDisplay.Font.Size = 30;
                    lblDisplay.ForeColor = System.Drawing.Color.Red;
                    lblDisplay.Text = "The password update successfully";
                }
                else 
                {
                    lblDisplay.Font.Size = 30;
                    lblDisplay.ForeColor = System.Drawing.Color.Red;
                    lblDisplay.Text = "Please try Again";
                    lblNewPassword.Visible = true;
                    txtNewPassword.Visible = true;
                    lblNewPassword1.Visible = true;
                    txtNewPassword1.Visible = true;
                    btnChangepassword.Visible = true;
                }

            }
            catch(Exception ex) 
            {
                lblDisplay.Font.Size = 30;
                lblDisplay.ForeColor = System.Drawing.Color.Red;
                lblDisplay.Text = "Error: " + ex.Message;
                lblNewPassword.Visible = true;
                txtNewPassword.Visible = true;
                lblNewPassword1.Visible = true;
                txtNewPassword1.Visible = true;
                btnChangepassword.Visible = true;
            }

        }
    }
}