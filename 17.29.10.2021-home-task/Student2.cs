using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._29._10._2021_home_task
{
    class Student2
    {

        public string fullName { get; set; }
        public string course { get; set; }
        public string subject { get; set; }
        public string university { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public Student2(string fullName, string email, string phone)
        {
            this.fullName = fullName;
            this.email = email;
            this.phone = phone;
        }

        public Student2(string fullName, string course, string subject, string university)
        {
            this.fullName = fullName;
            this.course = course;
            this.subject = subject;
            this.university = university;
        }

        public void fullInfo()
        {
            Console.WriteLine("Full name: " + fullName);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Subject: " + subject);
            Console.WriteLine("University: " + university);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Phone: " + phone);
        }
    }
}
