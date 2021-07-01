using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> myList = new List<Student>()
            {
                new Student(){Id = 001,Name = "SR Tipu",Age=25,Dept="ICT"},
                new Student(){Id = 002,Name = "Shawon",Age=24,Dept="ICT"},
                new Student(){Id = 003,Name = "Wakil",Age=25,Dept="CSE"},
                new Student(){Id = 004,Name = "Jahir",Age=26,Dept="ICT"}
            };
            Console.Write("Enter Search Department Name : ");
            string deptName = Console.ReadLine();

            var result = from s in myList
                         where s.Dept.ToLower() == deptName.ToLower()
                         select s;

            foreach (Student student in result)
            {
                Console.WriteLine("ID : " + student.Id + "\n" + "Name : " + student.Name + "\n" + "Age : " + student.Age);
            }

            Console.ReadKey();
        }
    }
}
