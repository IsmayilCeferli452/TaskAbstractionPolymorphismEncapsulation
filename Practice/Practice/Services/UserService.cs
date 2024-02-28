using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Services
{
    internal class UserService
    {
        public User[] GetAll()
        {
            User user1 = new()
            {
                id = 1,
                fullName = "Test1 Testov",
                address = "Baku",
                age = 18,
                email = "test1@mail.ru",
                password = "test1qwerty",
            };

            User user2 = new()
            {
                id = 2,
                fullName = "Test2 Testov",
                address = "Gandja",
                age = 28,
                email = "test2@gmail.com",
                password = "test2qwerty",
            };

            User user3 = new()
            {
                id = 3,
                fullName = "Test3 Testov",
                address = "Sumghayit",
                age = 38,
                email = "test3@mail.ru",
                password = "test3qwerty",
            };

            User user4 = new()
            {
                id = 4,
                fullName = "Test4 Testov",
                address = "Kedabek",
                age = 48,
                email = "test4@gmail.com",
                password = "test4qwerty",
            };

            User[] users = { user1, user2, user3, user4, };
            return users;
        }

        public User GetById(User[] users, int id) => users.FirstOrDefault(m => m.id == id);


    }
}
