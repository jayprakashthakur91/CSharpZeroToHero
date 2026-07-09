using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Zero_to_Hero.Chapter19._5
{
    public class AccessModifiersExample
    {
        public AccessModifiersExample()
        {
            Console.WriteLine("This is a public constructor.");
        }
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("HelloWold");
        //    Student student = new Student("Ram", 20);
        //    student.DisplayInfo();
        //}
    }
    public class Student
    {
        private string _name;
        private int _age;
        public Student(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {_name}, Age: {_age}");
        }
    }
}
