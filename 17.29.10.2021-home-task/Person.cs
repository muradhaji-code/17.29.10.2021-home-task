using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._29._10._2021_home_task
{
    class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public byte age { get; set; }

        public void Greet()
        {
            Console.WriteLine("Hello " + name + " " + surname + "!");
        }
        public void SetAge(byte newAge)
        {
            this.age = newAge;
        }
    }
}
