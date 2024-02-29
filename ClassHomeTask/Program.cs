using System.Security.Principal;

namespace ClassHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Admin", "AdminEA18yr@");
            Console.WriteLine(account.Username);
            Console.WriteLine(account.Password);
            account.LoginName();

            Console.WriteLine("=============");



            Register register = new Register("Kamran", "Baxsaliyev", "+995555583222", "Kamran1998", "Kisi");
            Console.WriteLine(register.Firstname); Console.WriteLine(register.Lastname); Console.WriteLine(register.PhoneNumberOrEmail);
            Console.WriteLine(register.Password);  Console.WriteLine(register.Gender);
            Console.WriteLine("=========================");
            register.GetFullInfo();
        }
    }
}
