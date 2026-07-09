using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Zero_to_Hero.Chapter20_Exception
{
   
    class MyResource : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Resources Released");
        }
    }

    class Program
    {
        //static void Main()
        //{
        //    using (MyResource obj = new MyResource())
        //    {
        //        Console.WriteLine("Using Resource");
        //    }
        //}
    }
}
