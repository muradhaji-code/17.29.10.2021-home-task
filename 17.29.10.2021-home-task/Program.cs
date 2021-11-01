using System;

namespace _17._29._10._2021_home_task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1, 2, 3, 4, 5
            //Car myCar = new Car
            //{
            //    brand = "BMW",
            //    model = "M5",
            //    color = "Black",
            //    doorCount = 4,
            //    fuelCapacity = 65,
            //    consumption = 8.3F
            //};
            //myCar.getBrandAndModel();
            //Console.WriteLine("This car can go: " + myCar.howManyKmCanGo() + " km with full tank.");

            //Bicycle myBicycle = new Bicycle
            //{
            //    brand = "Leader Scout",
            //    model = "MTB",
            //    color = "turqoise",
            //    wheelSize = 26,
            //};
            //myBicycle.getBrandAndModel();
            #endregion

            #region Task 6
            //Employee myEmployee = new Employee
            //{
            //    name = "John",
            //    surname = "Doe",
            //    dailySalary = 20,
            //};
            //Console.WriteLine("Monthly salary: " + myEmployee.monthlySalary());
            #endregion

            #region Task 7
            //Student myStudent = new Student
            //{
            //    name = "John",
            //    surname = "Doe"
            //};
            //myStudent.Greet();
            //myStudent.Study();
            //myStudent.SetAge(21);
            //myStudent.ShowAge();

            //Teacher myTeacher = new Teacher
            //{
            //    name = "Lorem",
            //    surname = "Ipsum"
            //};
            //myTeacher.Greet();
            //myTeacher.Explain();
            #endregion

            #region Task 8
            //Cube myCube = new Cube
            //{
            //    width = 2,
            //    length = 3,
            //    height = 4
            //};
            //Console.WriteLine("Volume of {width: 2, length: 3, height: 4} = " + volumeOfBox(myCube));
            #endregion

            #region Task 9
            Student2 myStudent1 = new Student2("John Doe", "john.doe@mail.com", "(012) 345 67 89");
            myStudent1.fullInfo();
            Console.WriteLine();
            Student2 myStudent2 = new Student2("John Doe", "IV", "Information Technology", "Oxford");
            myStudent2.fullInfo();
            #endregion
        }

        static int volumeOfBox(Cube props)
        {
            return props.width * props.length * props.height;
        }

        class Cube
        {
            public int width { get; set; }
            public int length { get; set; }
            public int height { get; set; }
        }
    }
}
