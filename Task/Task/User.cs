using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task
{
    internal class User
    {
        public string name;
        public string surname;
        private string password;
        public int age;


        public User(string name, string surname, int age, string password)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.password = password;
        }

        public string Get(string password) => password;

        public void Set(string password)
        {
            this.password = password;
        }

        public void ShowPassword()
        {
            Console.WriteLine(password);
        }
    }
}
