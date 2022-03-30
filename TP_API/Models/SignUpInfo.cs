using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using CIS_3342_TeamProject;

namespace CIS_3342_TeamProject.Class
{
    public class SignUpInfoClass
    {
        private String number;
        private String email;
        private String firstname;
        private String lastname;
        private String address1;
        private String address2;
        private String city;
        private String state;
        private int zip;
        private String billingfirstname;
        private String billinglastname;
        private String billingaddress1;
        private String billingaddress2;
        private String billingcity;
        private String billingstate;
        private int billingzip;
        private String password;
        private String question1;
        private String question2;
        private String question3;
        private String answer1;
        private String answer2;
        private String answer3;
        public SignUpInfoClass()
        {
        }
        public SignUpInfoClass(String password, String email)
        {
            this.Password = password;
            this.Email = email;
        }

        public String Number
        {
            get { return number; }
            set { number = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public String LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public String Address1
        {
            get { return address1; }
            set { address1 = value; }
        }
        public String Address2
        {
            get { return address2; }
            set { address2 = value; }
        }
        public String City
        {
            get { return city; }
            set { city = value; }
        }
        public String State
        {
            get { return state; }
            set { state = value; }
        }
        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }
        public String BillingFirstName
        {
            get { return billingfirstname; }
            set { billingfirstname = value; }
        }
        public String BillingLirstName
        {
            get { return billinglastname; }
            set { billinglastname = value; }
        }
        public String BillingAddress1
        {
            get { return billingaddress1; }
            set { billingaddress1 = value; }
        }
        public String BillingAddress2
        {
            get { return billingaddress2; }
            set { billingaddress2 = value; }
        }
        public String BillingCity
        {
            get { return billingcity; }
            set { billingcity = value; }
        }
        public String BillingState
        {
            get { return billingstate; }
            set { billingstate = value; }
        }
        public int BillingZip
        {
            get { return billingzip; }
            set { billingzip = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Answer1
        {
            get { return answer1; }
            set { answer1 = value; }
        }

        public String Answer2
        {
            get { return answer2; }
            set { answer2 = value; }
        }

        public String Answer3
        {
            get { return answer3; }
            set { answer3 = value; }
        }

        public String Question1
        {
            get { return question1; }
            set { question1 = value; }
        }

        public String Question2
        {
            get { return question2; }
            set { question2 = value; }
        }

        public String Question3
        {
            get { return question3; }
            set { question3 = value; }
        }
    }

}