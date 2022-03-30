using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS_3342_TeamProject.Class
{
    public class Service
    {
        private String servicename;
        private double servicerate;
        private int user;
        private int serviceid;
        private String servicetime;
        public string Servicename { get => servicename; set => servicename = value; }
        public double Servicerate { get => servicerate; set => servicerate = value; }
        public int Serviceid { get => serviceid; set => serviceid = value; }
        public int User { get => user; set => user = value; }
        public string Servicetime { get => servicetime; set => servicetime = value; }
    }
}

