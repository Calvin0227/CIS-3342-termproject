using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class PasswordChange
    {
        private String email;

        public String Email { get; set; }

        private String q1;
        public String Q1 { get; set; }

        private String q2;
        public String Q2 { get; set; }

        private String q3;
        public String Q3 { get; set; }

        private String password;
        public String Password { get; set; }

        public PasswordChange(){}

        public PasswordChange(String passwprd) 
        {
            this.Password = password;
        }

    }
}
