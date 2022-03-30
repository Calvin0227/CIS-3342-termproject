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
    public partial class MainPage : System.Web.UI.Page
    {
        String webAPIurl = "https://localhost:44326/api/cars/";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((string)Session["CustomerID"]))
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    gvCars.DataSource = returnAllCars();

                    gvCars.DataBind();
                }
            }
        }


        protected void btnAll_Click(object sender, EventArgs e)
        {

            // Bind the list to the GridView to display all cars.

            gvCars.DataSource = returnAllCars();

            gvCars.DataBind();

        }

        public List<Cars> returnAllCars()
        {

            WebRequest request = WebRequest.Create(webAPIurl + "GetAllCars");

            WebResponse response = request.GetResponse();

            // Read the data from the Web Response, which requires working with streams.

            Stream theDataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(theDataStream);

            String data = reader.ReadToEnd();

            reader.Close();

            response.Close();

            // Deserialize a JSON string that contains an array of JSON objects into an Array of Team objects.

            JavaScriptSerializer js = new JavaScriptSerializer();

            List<Cars> cars = js.Deserialize<List<Cars>>(data);

            return cars;

        }

        public List<Cars> returnCarType(string type)
        {

            string url = "https://localhost:44326/api/cars/";

            WebRequest request = WebRequest.Create(url + "Getcarbytype/" + type);

            WebResponse response = request.GetResponse();

            // Read the data from the Web Response, which requires working with streams.

            Stream theDataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(theDataStream);

            String data = reader.ReadToEnd();

            reader.Close();

            response.Close();

            // Deserialize a JSON string that contains an array of JSON objects into an Array of Team objects.

            JavaScriptSerializer js = new JavaScriptSerializer();

            List<Cars> cars = js.Deserialize<List<Cars>>(data);

            return cars;

        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            gvCars.DataSource = returnCarType("New");
            gvCars.DataBind();
        }

        protected void btnUsed_Click(object sender, EventArgs e)
        {
            gvCars.DataSource = returnCarType("Used");
            gvCars.DataBind();
        }

        protected void gvCars_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvCars.Rows[index];

                string carID = (row.FindControl("lblID") as Label).Text;

                Session["CarID"] = carID;

                Response.Redirect("CarDetailPage.aspx");

            }
        }

    }
}