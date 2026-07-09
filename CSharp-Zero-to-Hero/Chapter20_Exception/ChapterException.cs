using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Zero_to_Hero.Chapter20_Exception
{
    internal class ChapterException
    {
        //static void Main()
        //{
        //    try
        //    {
        //        Student student = new Student();
        //        student = null;
        //        student.GetName();

        //        //Method1();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Main Catch:");
        //        Console.WriteLine(ex);
        //    }
        //}

        static void Method1()
        {
            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Method1 Catch",ex.Message,ex.StackTrace);

                // Re-throw original exception
                throw;
            }
        }

        static void Method2()
        {
            int x = 0;
            int y = 10 / x;
        }

    }
    class Student
    {
        public int Id { get; set; }
        public string GetName()
        {
            return "Dev Journey By JP";
        }
    }
}
