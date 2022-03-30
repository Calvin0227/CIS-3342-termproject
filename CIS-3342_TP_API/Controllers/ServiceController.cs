using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;              // import needed for DataSet and other data classes

using System.Data.SqlClient;    // import needed for ADO.NET classes

using Utilities;                // import needed for DBConnect class

//inserting record/storing data     post
//getting data    get
//update   put
//delete  delete

namespace WebAPIAPI.Controllers
{
    [Route("api/[controller]")]   // default route : http://.../api/Service
    
    public class ServiceController : Controller
    {
        [HttpGet]
        public String Get() 
        {
            return "Welcome To The Service Center";
        }

        [HttpGet("DisplayAll")]

        public List<Service> Get() 
        {

        }
    }
}
