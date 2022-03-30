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
    public partial class CarDetailPage : System.Web.UI.Page
    {
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
                    string carid = Session["CarID"].ToString();

                    populateCar(int.Parse(carid));
                }
            }
        }

        public void populateCar(int id)
        {
            List<Cars> carDetail = new List<Cars>();

            carDetail = MyMethods.getCarByID(id);

            foreach(var car in carDetail)
            {
                imgRest.Src = car.CarPicture.ToString();
                lblCarMake.Text = car.CarMake.ToString();
                lblCarModel.Text = car.CarModel.ToString();
                lblCarYear.Text = car.CarYear.ToString();
                lblCarPrice.Text = car.CarPrice.ToString();
                lblCarVin.Text = car.CarVin.ToString();
                lblSpecs.Text = car.CarDesc.ToString();
                lblCarColor.Text = car.CarColor.ToString();
            }
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("CheckoutPage.aspx");
        }
    }
}