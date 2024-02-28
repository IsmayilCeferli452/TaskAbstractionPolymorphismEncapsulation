using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Models
{
    internal class Animal
    {
        public string Name { get; set; }

        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }

    }
}
