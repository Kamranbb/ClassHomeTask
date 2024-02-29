using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomeTask
{
    internal class Account
    {
    public string Username;
    public string Password;

        
        public Account (string username ,string password)
        {
            Username=username;
            Password = password;
        }

        public void LoginName ()
        {
            if (Username == "admin" || Password == "AdminEA18yr@")
            {
                Console.WriteLine("giris ugurludur");
            }
            else 
            {
                Console.WriteLine("email ve ya password yanlisdir");
            }
        }
    
    
    
    
    
    
    }
}
