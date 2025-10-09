using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Zero_to_Hero.Chapter05_Identifier_DataType
{
    public class Identifier
    {
        public Identifier()
        {
            int employeeId= 2147483647;
            long employeeIDLong = 2147483648L;
            Console.WriteLine("sum"+ employeeId);
            Console.WriteLine("sum" + employeeIDLong);
        }
    }
}
