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
    [Route("api/[controller]")]
    public class ServicesController : Controller
    {
        // default route GET api/Services
        [HttpGet]

        [HttpGet("DisplayAll")] // api/Services/DisplayAll
        public List<Services> Get()
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "[TP_DisplayAllServiceForAdmin]";
            DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand);
            List<Services> services = new List<Services>();
            Services service;

            foreach (DataRow record in ds.Tables[0].Rows)
            {
                service = new Services();
                service.HourlyRate = float.Parse(record["HourlyRate"].ToString());
                service.ServiceName = record["ServiceName"].ToString();
                service.ServiceID = int.Parse(record["ServiceTypeID"].ToString());


                services.Add(service);
            }

            return services;
        }


        [HttpGet("{id}")]

        public Services Get(int id)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "[TP_FindServiceByID]";
            SqlParameter input = new SqlParameter("@ID", id);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.Int;
            input.Size = 10;
            objCommand.Parameters.Add(input);

            DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand);
            DataRow record;
            Services objservice = new Services();

            if (ds.Tables[0].Rows.Count != 0)
            {
                record = ds.Tables[0].Rows[0];
                objservice.ServiceName = record["ServiceName"].ToString();
                objservice.ServiceID = int.Parse(record["ServiceTypeID"].ToString());
                objservice.HourlyRate = float.Parse(record["HourlyRate"].ToString());
            }
            return objservice;



        }

        [HttpDelete("DeleteService/{name}")]
        public int delete([FromBody]int id) 
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "[TP_DeleteService]";
            SqlParameter input = new SqlParameter("@serviceid", id);
            input.Direction = ParameterDirection.Input;
            input.SqlDbType = SqlDbType.Int;
            input.Size = 10;
            objCommand.Parameters.Add(input);

            int result = objDB.DoUpdateUsingCmdObj(objCommand);
            return result;
        }
    }
}
