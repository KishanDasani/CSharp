using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaAssignDay2_Program3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 5;
            int value2 = 10;

            Console.WriteLine("Values before swapping : \nValue1 = " + value1 + " Value2 = " + value2);

            value1 = value1 + value2;
            value2 = value1 - value2;
            value1 = value1 - value2;

            Console.WriteLine("Values after swapping : \nValue1 = " + value1 + " Value2 = " + value2);
            Console.ReadLine();
        }
    }
}
