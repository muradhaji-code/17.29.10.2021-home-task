using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._29._10._2021_home_task
{
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is: " + age + " years old");
        }
    }
}
