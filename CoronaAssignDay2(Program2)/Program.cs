using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaAssignDay2_Program2_
{
    class Program
    {
        static void Main(string[] args)
        {
            float var1 = 1.123459f;
            float var2 = 1.123457f;

            Console.WriteLine("Given Values are : " + var1 + " and " + var2);

            if (var1>var2)
            {
                Console.WriteLine("Greater Value is " + var1);
            }
            else if(var1<var2)
            {
                Console.WriteLine("Greater Value is " + var2);
            }
            else
            {
                Console.WriteLine("Both values are equal");
            }
            Console.ReadLine();
        }
    }
}
