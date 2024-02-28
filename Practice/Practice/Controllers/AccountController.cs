using Practice.Helpers.Constants;
using Practice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Controllers
{
    internal class AccountController
    {
        private readonly AccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }

        public void SignIn()
        {

            Console.WriteLine("Please add email:");
            Email: string email = Console.ReadLine();

            if (!email.Contains("@"))
            {
                Console.WriteLine(ResponseMessages.EmailFormatWrong);
                goto Email;
            }

            Console.WriteLine("Please add password:");
            string password = Console.ReadLine();

            var result = _accountService.Login(email, password);

            if (result)
            {
                Console.WriteLine(ResponseMessages.LoginSuccess);               
            }
            else
            {
                Console.WriteLine(ResponseMessages.EmailPassWrong);
                goto Email;
            }
        }
    }
}
