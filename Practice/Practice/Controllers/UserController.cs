using Practice.Helpers.Constants;
using Practice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Controllers
{
    internal class UserController
    {
        private readonly UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        public void ShowAll()
        {
            var users = _userService.GetAll();

            foreach (var user in users)
            {
                Console.WriteLine($"|Full name: {user.fullName} | Address: {user.address} | Email: {user.email} |");
            }
        }

        public void ShowById()
        {
            Console.WriteLine("Please add Id:");
            Id:  string stringId = Console.ReadLine();

            int id;

            bool idIsCorrect = int.TryParse(stringId, out id);


            if (idIsCorrect)
            {
                var user = _userService.GetById(_userService.GetAll(), id);

                if (user != null)
                {
                    string result = $"| Full name:{user.fullName} | Address:{user.address} | Email:{user.email} |";

                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine(ResponseMessages.UserNotFound);
                    return;
                }
            }
            else
            {
                Console.WriteLine(ResponseMessages.NumberFormatWrong);
                goto Id;
            }
        }
    }
}
