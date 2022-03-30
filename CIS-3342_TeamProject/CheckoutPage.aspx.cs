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
    public partial class CheckoutPage : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)Session["CustomerID"]))
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                int id = int.Parse((string)Session["CustomerID"]);
                string carid = Session["CarID"].ToString();

                if (!IsPostBack)
                {
                    accountInfo(id);
                    
                populateCar(int.Parse(carid));
                }
            }
        }

        public void accountInfo(int accountID)
        {

            List <Customers> accountInfo= new List<Customers>();

            accountInfo = returnAccount(accountID);

            foreach(var cust in accountInfo)
            {
                lblFirstName.Text = cust.FirstName.ToString();
                lblLastName.Text = cust.LastName.ToString();
                lblShipping.Text = cust.Address1.ToString() + " " + cust.Address2.ToString() + " " + cust.City.ToString() + " " + 
                    cust.State.ToString() + " " + cust.Zip.ToString();
                lblBilling.Text = cust.BillingAddress1.ToString() + " " + cust.BillingAddress2.ToString() + " " + cust.BillingCity + 
                    " " + cust.BillingState + " " + cust.BillingZip;
                lblNumber.Text = cust.Number.ToString();
                lblEmail.Text = cust.Email.ToString();

            }

        }

        public void populateCar(int id)
        {
            List<Cars> carDetail = new List<Cars>();

            carDetail = MyMethods.getCarByID(id);

            foreach (var car in carDetail)
            {
                imgRest.Src = car.CarPicture.ToString();
                lblCarMake.Text = car.CarMake.ToString();
                lblCarModel.Text = car.CarModel.ToString();
                lblCarYear.Text = car.CarYear.ToString();
                lblPrice.Text = car.CarPrice.ToString();
                lblVin.Text = car.CarVin.ToString();
                lblCarColor.Text = car.CarColor.ToString();
            }
        }

        public static List<Customers> returnAccount(int accountID)
        {
            string webAPIurl = "https://localhost:44326/api/customer/";

            WebRequest request = WebRequest.Create(webAPIurl + accountID);

            WebResponse response = request.GetResponse();

            // Read the data from the Web Response, which requires working with streams.

            Stream theDataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(theDataStream);

            String data = reader.ReadToEnd();

            reader.Close();

            response.Close();

            // Deserialize a JSON string that contains an array of JSON objects into an Array of Team objects.

            JavaScriptSerializer js = new JavaScriptSerializer();

            List<Customers> customers = js.Deserialize<List<Customers>>(data);

            return customers;

        }

        public static int addSales(int accountID, int carID)
        {
            string webAPIurl = "https://localhost:44326/api/customer/";

            WebRequest request = WebRequest.Create(webAPIurl + "addSales/" + accountID + "/" + carID);

            WebResponse response = request.GetResponse();

            // Read the data from the Web Response, which requires working with streams.

            Stream theDataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(theDataStream);

            String data = reader.ReadToEnd();

            reader.Close();

            response.Close();

            // Deserialize a JSON string that contains an array of JSON objects into an Array of Team objects.
                       

            return int.Parse(data);

        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {

            int accountid = int.Parse((string)Session["CustomerID"]);
            int carid = int.Parse((string)Session["CarID"]);

            int validate = addSales(accountid, carid);

            if (validate == 1)
            {
                popup.Visible = true;
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#popup').modal();", true);
            }
            else
            {

            }

        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }
    }
}