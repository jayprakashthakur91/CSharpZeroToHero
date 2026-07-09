using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Zero_to_Hero.Chapter20_Exception
{
    internal class FianllyExample
    {
        //use the finally block to execute code regardless of whether an exception is thrown or not
        //static void Main()
        //{
        //    try
        //    {
        //        Console.WriteLine("Inside try block");
        //        int x = 10;
        //        int y = 0;
        //        int z = x / y; // This will throw a DivideByZeroException
        //    }
        //    catch (DivideByZeroException ex)
        //    {
        //        Console.WriteLine("Caught an exception: " + ex.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("This will always execute, regardless of exceptions.");
        //    }
        //}

        //file read operation example with finally block
        //static void Main()
        //{
        //    System.IO.StreamReader reader = null;
        //    try
        //    {
        //        reader = new System.IO.StreamReader("nonexistentfile.txt");
        //        string content = reader.ReadToEnd();
        //        Console.WriteLine(content);
        //    }
        //    catch (System.IO.FileNotFoundException ex)
        //    {
        //        Console.WriteLine("Caught an exception: " + ex.Message);
        //    }
        //    finally
        //    {
        //        if (reader != null)
        //        {
        //            reader.Close();
        //            Console.WriteLine("StreamReader closed in finally block.");
        //        }
        //    }

        //}
    }
}

