using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utilities;
using System.Data;
using System.Net;

using System.Data.SqlClient;

namespace CIS_3342_TeamProject.Class
{
    public class MyMethods
    {


        public static int AddingRegistrationInfoIntoTable(SignUpInfoClass objSignUpInfo)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "[TP_StoreRegistrationInfo]";

            SqlParameter inputParameter = new SqlParameter("@phonenumber", objSignUpInfo.Number);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@email", objSignUpInfo.Email);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 100;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@firstname", objSignUpInfo.FirstName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@lastname", objSignUpInfo.LastName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@address1", objSignUpInfo.Address1);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 100;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@address2", objSignUpInfo.Address2);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 100;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@city", objSignUpInfo.City);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@state", objSignUpInfo.State);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@zip", objSignUpInfo.Zip);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 10;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@billingfirstname", objSignUpInfo.BillingFirstName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@billinglastname", objSignUpInfo.BillingLirstName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@billingaddress1", objSignUpInfo.BillingAddress1);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 100;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@billingaddress2", objSignUpInfo.BillingAddress2);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 100;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@billingcity", objSignUpInfo.BillingCity);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@billingstate", objSignUpInfo.BillingState);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@billingzip", objSignUpInfo.BillingZip);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            inputParameter.Size = 10;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@password", objSignUpInfo.Password);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 100;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Q1", objSignUpInfo.Answer1);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 100;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Q2", objSignUpInfo.Answer2);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 100;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Q3", objSignUpInfo.Answer3);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 100;
            objCommand.Parameters.Add(inputParameter);

            int Result = objDB.DoUpdateUsingCmdObj(objCommand);
            return Result;
        }
        //public static void UpdatingQuestion1(SignUpInfoClass objSignUpInfo) 
        //{
        //    String Q1 = objSignUpInfo.Question1;

        //}

        public static int AddingServiceINfoIntoTable(Service objservice) 
        {
            DBConnect dbobj = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "[TP_StoreServiceInfo]";

            SqlParameter inputParameter = new SqlParameter("@ServiceName", objservice.Servicename);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@ServiceRate", objservice.Servicerate);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Float;
            inputParameter.Size = 20;
            objCommand.Parameters.Add(inputParameter);

            int Result = dbobj.DoUpdateUsingCmdObj(objCommand);
            return Result;
        }


        public static int GerUserID(SignUpInfoClass objinfo) 
        {
            try
            {
                DBConnect objDB = new DBConnect();
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "[TP_GetUserID]";

                SqlParameter inputParameter = new SqlParameter("@UserName", objinfo.Email);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                inputParameter.Size = 100;
                objCommand.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@Password", objinfo.Password);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                inputParameter.Size = 100;
                objCommand.Parameters.Add(inputParameter);

                SqlParameter outputParameter = new SqlParameter("@UserID", SqlDbType.Int);
                outputParameter.Direction = ParameterDirection.Output;
                objCommand.Parameters.Add(outputParameter);
                objDB.GetDataSetUsingCmdObj(objCommand);
                int result;
                result = int.Parse(objCommand.Parameters["@UserID"].Value.ToString());
                return result;
            }
            catch 
            {
                return -1;
            }
        }

        public static int AddingServiceDetails(Service objservice) 
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "[TP_AddingServiceOrderDetails]";
            
            SqlParameter inputparameter = new SqlParameter("@CustomerID", objservice.User);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.Int;
            inputparameter.Size = 10;
            objCommand.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@ServicetypeID", objservice.Serviceid);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.Int;
            inputparameter.Size = 10;
            objCommand.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@Time", objservice.Servicetime);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            objCommand.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@Total", objservice.Servicerate);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.Float;
            inputparameter.Size = 20;
            objCommand.Parameters.Add(inputparameter);

            int result = objDB.DoUpdateUsingCmdObj(objCommand);
            return result;
             
        }

        public static List<Cars> getCarByID(int id)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_GetCarsByID";

            SqlParameter typeParameter = new SqlParameter("@carID", id);
            typeParameter.Direction = ParameterDirection.Input;
            typeParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(typeParameter);

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);

            List<Cars> allCars = new List<Cars>();
            Cars cars;

            foreach (DataRow record in myDS.Tables[0].Rows)
            {
                cars = new Cars();
                cars.CarID = int.Parse(record["CarID"].ToString());
                cars.CarMake = record["CarMake"].ToString();
                cars.CarModel = record["CarModel"].ToString();
                cars.CarDesc = record["CarDesc"].ToString();
                cars.CarPrice = int.Parse(record["CarPrice"].ToString());
                cars.CarType = record["CarType"].ToString();
                cars.CarVin = record["CarVin"].ToString();
                cars.CarColor = record["CarColor"].ToString();
                cars.CarYear = record["CarYear"].ToString();
                cars.CarPicture = record["CarPicture"].ToString();

                allCars.Add(cars);
            }

            return allCars;
        }

        public static List<Customers> getAccount(string email, string password)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_GetAccountByID";

            SqlParameter emailParameter = new SqlParameter("@accountEmail", email);
            emailParameter.Direction = ParameterDirection.Input;
            emailParameter.SqlDbType = SqlDbType.VarChar;
            emailParameter.Size = 500;
            objCommand.Parameters.Add(emailParameter);

            SqlParameter passwordParameter = new SqlParameter("@accountPassword", password);
            passwordParameter.Direction = ParameterDirection.Input;
            passwordParameter.SqlDbType = SqlDbType.VarChar;
            passwordParameter.Size = 500;
            objCommand.Parameters.Add(passwordParameter);

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

        public static DataSet CheckAccount(SignUpInfoClass objinfo) 
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_CheckThisAccount";

            SqlParameter passwordParameter = new SqlParameter("@email", objinfo.Email);
            passwordParameter.Direction = ParameterDirection.Input;
            passwordParameter.SqlDbType = SqlDbType.VarChar;
            passwordParameter.Size = 100;
            objCommand.Parameters.Add(passwordParameter);

            passwordParameter = new SqlParameter("@Q1", objinfo.Answer1);
            passwordParameter.Direction = ParameterDirection.Input;
            passwordParameter.SqlDbType = SqlDbType.VarChar;
            passwordParameter.Size = 100;
            objCommand.Parameters.Add(passwordParameter);

            passwordParameter = new SqlParameter("@Q2", objinfo.Answer2);
            passwordParameter.Direction = ParameterDirection.Input;
            passwordParameter.SqlDbType = SqlDbType.VarChar;
            passwordParameter.Size = 100;
            objCommand.Parameters.Add(passwordParameter);

            passwordParameter = new SqlParameter("@Q3", objinfo.Answer3);
            passwordParameter.Direction = ParameterDirection.Input;
            passwordParameter.SqlDbType = SqlDbType.VarChar;
            passwordParameter.Size = 100;
            objCommand.Parameters.Add(passwordParameter);

            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        public static void DisplayAllCustomer() 
        {
            
        }
    }
}