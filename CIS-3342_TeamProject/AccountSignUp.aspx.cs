using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Net;
using CIS_3342_TeamProject.Class;

namespace CIS_3342_TeamProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.Cookies["LoginDetail"] != null)
            {
                HttpCookie cookie = Request.Cookies["LoginDetail"];
                lblNotification.BackColor = System.Drawing.Color.Aqua;
                lblNotification.Text = "We have your record, heres your username:  " + cookie.Values["Username"].ToString();
            }
        }

        protected void btnNextStep_Click(object sender, EventArgs e)
        {
            int result = 0;
            result = RetrieveInfo();
            if (result == 1)
            {
                CheckBox cbox = (CheckBox)FindControl("cboxEmail");
                if (cbox.Checked)
                {
                    SendConfirmationEmail();
                    GerUserID();
                }
                else
                {
                    GerUserID();
                }
            }
            else 
            {
                lblError.Text = "Please make sure you enter the right into";
            }
        }

        public int RetrieveInfo()
        {

            String error = InputCheck();
            int result = 0;
            if (error == "")
            {
                SignUpInfoClass objSignUpInfo;
                objSignUpInfo = new SignUpInfoClass();
                CheckBox cbox = (CheckBox)FindControl("CboxSameBilling");
                CheckBox CboxCookie = (CheckBox)FindControl("cboxSaveCookie");
                if (cbox.Checked)
                {
                    try
                    {
                        objSignUpInfo.Number = txtPhoneNumber.Text;
                        objSignUpInfo.Email = txtEmailAddress.Text;
                        objSignUpInfo.FirstName = txtFirstName.Text;
                        objSignUpInfo.LastName = txtLastName.Text;
                        objSignUpInfo.Address1 = txtHomeAddress1.Text;
                        objSignUpInfo.Address2 = txtHomeAddress2.Text;
                        objSignUpInfo.City = txtHomeAddressCity.Text;
                        objSignUpInfo.State = txtHomeAddressState.Text;
                        objSignUpInfo.Zip = int.Parse(txtHomeAddressZip.Text);
                        objSignUpInfo.BillingFirstName = txtFirstName.Text;
                        objSignUpInfo.BillingLirstName = txtLastName.Text;
                        objSignUpInfo.BillingAddress1 = txtHomeAddress1.Text;
                        objSignUpInfo.BillingAddress2 = txtHomeAddress2.Text;
                        objSignUpInfo.BillingCity = txtHomeAddressCity.Text;
                        objSignUpInfo.BillingState = txtHomeAddressState.Text;
                        objSignUpInfo.BillingZip = int.Parse(txtHomeAddressZip.Text);
                        objSignUpInfo.Password = txtPassword.Text;
                        objSignUpInfo.Answer1 = txtQ1Answer.Text;
                        objSignUpInfo.Answer2 = txtQ2Answer.Text;
                        objSignUpInfo.Answer3 = txtQ3Answer.Text;
                        if (CboxCookie.Checked)
                        {
                            CollectLoginForCookie();
                        }
                    }
                    catch
                    {
                        lblError.Text = "Error" + error;
                    }
                }
                else
                {
                    try
                    {
                        objSignUpInfo = new SignUpInfoClass();
                        objSignUpInfo.Number = txtPhoneNumber.Text;
                        objSignUpInfo.Email = txtEmailAddress.Text;
                        objSignUpInfo.FirstName = txtFirstName.Text;
                        objSignUpInfo.LastName = txtLastName.Text;
                        objSignUpInfo.Address1 = txtHomeAddress1.Text;
                        objSignUpInfo.Address2 = txtHomeAddress2.Text;
                        objSignUpInfo.City = txtHomeAddressCity.Text;
                        objSignUpInfo.State = txtHomeAddressState.Text;
                        objSignUpInfo.Zip = int.Parse(txtHomeAddressZip.Text);
                        objSignUpInfo.BillingFirstName = txtBillingFirstName.Text;
                        objSignUpInfo.BillingLirstName = txtBillingLastName.Text;
                        objSignUpInfo.BillingAddress1 = txtBillingAddress1.Text;
                        objSignUpInfo.BillingAddress2 = txtBillingAddress2.Text;
                        objSignUpInfo.BillingCity = txtBillingCity.Text;
                        objSignUpInfo.BillingState = txtBillingState.Text;
                        objSignUpInfo.BillingZip = int.Parse(txtBillingZip.Text);
                        objSignUpInfo.Password = txtPassword.Text;
                        objSignUpInfo.Answer1 = txtQ1Answer.Text;
                        objSignUpInfo.Answer2 = txtQ2Answer.Text;
                        objSignUpInfo.Answer3 = txtQ3Answer.Text;
                        if (CboxCookie.Checked)
                        {
                            CollectLoginForCookie();
                        }
                    }
                    catch
                    {
                        lblError.Text = "Please Make Sure You Fill out all the textbox";
                    }

                }

                result = MyMethods.AddingRegistrationInfoIntoTable(objSignUpInfo);
            }
            else
            {
                lblNotification.Text = error;
            }
            return result;

        }

        public String InputCheck()
        {
            String error = "";
            String email = txtEmailAddress.Text;
            String firstn = txtFirstName.Text;
            String lastn = txtLastName.Text;
            String add1 = txtHomeAddress1.Text;  
            String city = txtHomeAddressCity.Text;
            String state = txtHomeAddressState.Text;
            String num = txtPhoneNumber.Text;
            String Q1 = txtQ1Answer.Text;
            String Q2 = txtQ2Answer.Text;
            String Q3 = txtQ3Answer.Text;
            
            if (email == "")
            {
                error += "<i>Please Make Sure You entered right Email </i><br/>";
            }
            if (firstn == "" || lastn =="")
            {
                error += "<i>Please Make Sure You entered right Name </i><br/>";
            }
            if( add1 == "")
            {
                error += "<i>Please Make Sure You entered right Address </i><br/>";
            }
            if (city == "") 
            {
                error += "<i>Please Make Sure You entered right City </i><br/>";
            }
            if (state == "") 
            {
                error += "<i>Please Make Sure You entered right State </i><br/>";
            }
            try
            {
                int zip = int.Parse(txtHomeAddressZip.Text);
            }
            catch 
            {
                error += "<i>Please Make Sure You entered right zip </i><br/>";
            }
            if (num == "") 
            {
                error += "<i>Please Make Sure You entered right number </i><br/>";
            }
            if (Q1=="" || Q2=="" || Q3=="")
            {
                error += "<i>Please Make Sure You entered all security questions</i><br/>";
            }



            return error;



        }

        public void CollectLoginForCookie()
        {
            HttpCookie myCookie = new HttpCookie("LoginDetail");
            myCookie.Values["Username"] = txtEmailAddress.Text;
            myCookie.Values["Password"] = txtPassword.Text;
            myCookie.Expires = new DateTime(2022, 12, 1);
            Session["Name"] = txtFirstName.Text;
            Response.Cookies.Add(myCookie);
        }

        public void GerUserID()
        {
            SignUpInfoClass objSignUpInfo;
            objSignUpInfo = new SignUpInfoClass();
            objSignUpInfo.Email = txtEmailAddress.Text;
            objSignUpInfo.Password = txtPassword.Text;

            int ID = MyMethods.GerUserID(objSignUpInfo);
            Session["UserID"] = ID;
            Response.Redirect("LoginPage.aspx");
        }

        public void SendConfirmationEmail()
        {
            Email objEmail = new Email();
            String To = txtEmailAddress.Text;
            String Name = txtFirstName.Text;
            String From = "cis3342teamproject@gmail.com";
            String Subject = "Welcome To The Family  " +Name;
            String Message = "Welcome To The Family";

            try
            {
                objEmail.SendMail(To, From, Subject, Message);

            }
            catch
            {
                lblError.Text = "Please Make Sure You Fill out all the textbox";
            }
        }

        public void resetEmail() 
        {
            Email objEmail = new Email();
            String To = txtEmailAddress.Text;
            String From = "cis3342teamproject@gmail.com";
            String Subject = "Please click the link to make your account verified";
            String Message = "You can now click the link to reset the password https://localhost:44382/UpdatePassword.aspx";

            try
            {
                objEmail.SendMail(To, From, Subject, Message);

            }
            catch
            {
                lblError.Text = "Please Make Sure You Fill out all the textbox";
            }
        }
        protected void btnResetPassword_Click(object sender, EventArgs e)
        {
            String email = txtEmailAddress.Text;
            if (email == "")
            {
                lblNotification.Font.Size = 15;
                lblNotification.ForeColor = System.Drawing.Color.Red;
                lblNotification.Text = "Please Enter Email first, and we will send you reset password link";
            }
            else 
            {
                resetEmail();

                lblNotification.Font.Size = 15;
                lblNotification.ForeColor = System.Drawing.Color.Green;
                lblNotification.Text = "We sent you the reset password link through email already";
            }

            

        }
    }
}