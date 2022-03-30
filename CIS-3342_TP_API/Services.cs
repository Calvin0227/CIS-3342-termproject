using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json.Serialization;
namespace WebAPI
{
    public class Services
    {
        private int serviceid;
        public int ServiceID() 
        {
            get{ serviceid = value};
            set;
        }
    }
}
