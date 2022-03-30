using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP_API.Model
{
    public class Services
    {
        private int serviceid;
        private String servicename;
        private float hourlyrate;
        public float HourlyRate
        {
            get { return hourlyrate; }
            set { hourlyrate = value; }
        }
        public int ServiceID
        {
            get { return serviceid; }
            set { serviceid = value; }
        }
        public String ServiceName
        {
            get { return servicename; }
            set { servicename = value; }
        }
        public Services()
        {

        }

        public Services(int id, String servicename, float hourlyrate)
        {
            this.ServiceID = id;
            this.ServiceName = servicename;
            this.HourlyRate = hourlyrate;
        }

    }
}
