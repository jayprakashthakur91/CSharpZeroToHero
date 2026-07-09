using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Zero_to_Hero.Chapter19._6
{
    public class Employee
    {
        private double salary;
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Salary must be greater than 0");
                }

            }
        }


    }

}

