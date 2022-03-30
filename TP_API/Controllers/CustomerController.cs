using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilities;
using TP_API;
using CIS_3342_TeamProject.Class;


namespace TP_API.Controllers
{
    [Route("api/[controller]")]  //default route : api/Cars
    public class CustomerController : Controller
    {
        // default route GET api/Services
        [HttpGet]
        public string Get()
        {
            return "test API";
        }
        [HttpGet("DisplayAllCustomer")]
        public List<Customers> displayallcustomer()
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_DisplayAllCustomer";
            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            List<Customers> customer = new List<Customers>();
            Customers objcus;
            foreach (DataRow record in myDS.Tables[0].Rows)
            {
                objcus = new Customers();//CustomerID,FirstName, LastName,Status
                objcus.CustomerID = int.Parse(record["CustomerID"].ToString());
                objcus.FirstName = record["FirstName"].ToString();
                objcus.LastName = record["LastName"].ToString();
                objcus.Status = record["Status"].ToString();

                customer.Add(objcus);
            }
            return customer;
        }
        [HttpGet("{accountID}")] //api/Cars/
        public List<Customers> getAccount(int accountID)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_CheckoutAccountID";

            SqlParameter emailParameter = new SqlParameter("@accountID", accountID);
            emailParameter.Direction = ParameterDirection.Input;
            emailParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(emailParameter);

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            List<Customers> customer = new List<Customers>();
            Customers loginCust;

            foreach (DataRow record in myDS.Tables[0].Rows)
            {
                loginCust = new Customers();
                loginCust.CustomerID = int.Parse(record["CustomerID"].ToString());
                loginCust.FirstName = record["FirstName"].ToString();
                loginCust.LastName = record["LastName"].ToString();
                loginCust.Address1 = record["Address 1"].ToString();
                loginCust.Address2 = record["Address 2"].ToString();
                loginCust.City = record["City"].ToString();
                loginCust.State = record["State"].ToString();
                loginCust.Zip = int.Parse(record["ZipCode"].ToString());
                loginCust.BillingAddress1 = record["BillingAddress 1"].ToString();
                loginCust.BillingAddress2 = record["BillingAddress 2"].ToString();
                loginCust.BillingFirstName = record["BillingFirstName"].ToString();
                loginCust.BillingLastName = record["BillingLastName"].ToString();
                loginCust.BillingCity = record["BillingCity"].ToString();
                loginCust.BillingState = record["BillingState"].ToString();
                loginCust.BillingZip = int.Parse(record["BillingZipCode"].ToString());
                loginCust.Number = record["Number"].ToString();
                loginCust.Email = record["EmailAddress"].ToString();
                loginCust.Password = record["Password"].ToString();

                customer.Add(loginCust);
            }

            return customer;
        }


        [HttpGet("addSales/{accountid}/{carid}")]
        public int addSales(int accountid, int carid)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_AddSales";

            SqlParameter accountParameter = new SqlParameter("@CustomerID", accountid);
            accountParameter.Direction = ParameterDirection.Input;
            accountParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(accountParameter);

            SqlParameter carParameter = new SqlParameter("@VehicleId", carid);
            carParameter.Direction = ParameterDirection.Input;
            carParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(carParameter);

            return objDB.DoUpdateUsingCmdObj(objCommand);
        }

        [HttpPost("UpdatePassword")]
        public int post([FromBody] SignUpInfoClass objinfo)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_UpdatePassword";

            SqlParameter inputparameter = new SqlParameter("@password", objinfo.Password);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 100;
            objCommand.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@email", objinfo.Email);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 100;
            objCommand.Parameters.Add(inputparameter);

            int result = objDB.DoUpdateUsingCmdObj(objCommand);
            return result;
            //if (result > 0)
            //    return true;


            //return false;

        }


        [HttpPut]
        public int put([FromBody] Customers objcu) 
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_UpdateCustomerStatus";

            SqlParameter inputparameter = new SqlParameter("@status", objcu.Status);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            objCommand.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@id",objcu.CustomerID);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.Int;
            inputparameter.Size = 10;


            objCommand.Parameters.Add(inputparameter);

            int reuslt = objDB.DoUpdateUsingCmdObj(objCommand);
            return reuslt;
        }


    }
}
