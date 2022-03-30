using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilities;
using TP_API;

namespace TP_API.Controllers
{
    [Route("api/[controller]")]  //default route : api/Cars
    public class CarsController : Controller
    {
        // default route GET api/Services
        [HttpGet]
        public string Get()
        {
            return "test API";
        }

        [HttpGet("GetAllCars")] //api/Cars/
        public List<Cars> GetAllCars()
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_GetAllCars";

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

        [HttpGet("GetCarByType/{carType}")] //api/Cars/
        public List<Cars> GetCarByType(string carType)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_GetCarsByType";

            SqlParameter typeParameter = new SqlParameter("@carType", carType);
            typeParameter.Direction = ParameterDirection.Input;
            typeParameter.SqlDbType = SqlDbType.VarChar;
            typeParameter.Size = 50;
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

        [HttpGet("{carID}")] //api/Cars/
        public List<Cars> GetCarByID(int id)
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
    }
}
