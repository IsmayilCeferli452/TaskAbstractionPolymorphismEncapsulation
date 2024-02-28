using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Services
{
    internal class AccountService
    {
        private readonly UserService _userService;

        public AccountService()
        {
            _userService = new UserService();
        }

        public bool Login(string email, string password)
        {
            var users = _userService.GetAll();

            var user = users.FirstOrDefault(m => m.email == email && m.password == password);

            return user != null ? true : false; 
        }
    }
}
