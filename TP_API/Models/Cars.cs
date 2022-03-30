using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json.Serialization;

namespace TP_API
{
    public class Cars
    {
        public Cars()
        {

        }
        public String CarMake { get; set; }
        public String CarModel { get; set; }
        public String CarDesc { get; set; }
        public float CarPrice { get; set; }
        public String CarPicture { get; set; }
        public String CarType { get; set; }
        public String CarVin { get; set; }
        public String CarColor { get; set; }
        public String CarYear { get; set; }
        public int CarID { get; set; }
    }
}
