using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._29._10._2021_home_task
{
    class Car : Vehicle
    {
        //public string brand { get; set; }
        //public string model { get; set; }
        //public string color { get; set; }
        public byte doorCount { get; set; }
        public int fuelCapacity { get; set; }
        public float consumption { get; set; }

        //public void getBrandAndModel()
        //{
        //    Console.WriteLine(brand + " " + model);
        //}
        public float howManyKmCanGo()
        {
            return fuelCapacity / consumption * 100;
        }
    }
}
