using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Zero_to_Hero.Chapter19._3
{
    public class Student
    {
        public int rollNo;
        public string name;
        public string className;

        public Student(int _rollNo, string _name, string _className)
        {
            rollNo = _rollNo;
            name = _name;
            className = _className;
        }

        //public static void Main()
        //{
        //    Student s1 = new Student(1,"Jay","10");
        //    Student s2 = new Student(2, "Ram", "12");

        //    Console.WriteLine("Student RollNo:"+ s1.rollNo);
        //    Console.WriteLine("Student Name:"+ s1.name);
        //    Console.WriteLine("Student Class Name:"+ s1.className);

        //    Console.WriteLine("Student RollNo:"+ s2.rollNo);
        //    Console.WriteLine("Student Name:"+ s2.name);
        //    Console.WriteLine("Student Class Name:"+ s2.className);

        //    Console.ReadLine();
        //}
    }
}
