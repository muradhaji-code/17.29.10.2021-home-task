using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._29._10._2021_home_task
{
    class Employee
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string position { get; set; }
        public int dailySalary { get; set; }

        public int monthlySalary()
        {
            return dailySalary * DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
        }
    }
}
