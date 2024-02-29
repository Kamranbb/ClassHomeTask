using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomeTask
{
    internal class Register
    {
        public string Firstname; 
        public string Lastname;
        public string PhoneNumberOrEmail;
        public string Password;
        public string Gender;
        public DateTime BirthDay;

        public Register()
        {
            
        }
        public Register(string firstname ,string lastname ,string phonenumberoremail,string password ,string gender)
        {
            Firstname = firstname;
            Lastname= lastname;
            PhoneNumberOrEmail = phonenumberoremail;
            Password = password;
            Gender = gender;
        }
        public void GetFullInfo()
        {
            Console.WriteLine(Firstname+ " " + Lastname+ " " + PhoneNumberOrEmail+ " "+Password+  " "  +Gender);
        }

    }

    
}
