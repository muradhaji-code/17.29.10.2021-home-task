using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._29._10._2021_home_task
{
    class Vehicle
    {
        public string brand { get; set; }
        public string model { get; set; }
        public string color { get; set; }

        public void getBrandAndModel()
        {
            Console.WriteLine(brand + " " + model);
        }
    }
}
