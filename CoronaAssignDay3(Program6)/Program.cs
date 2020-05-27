using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaAssignDay3_Program6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Replace the bit value at 3 with bit value at 24, bit value at 4 with bit value at 25 and bit value at 5 with bit value at 26");
            Console.Write("Enter number: ");
            int v;
            bool v1  = Int32.TryParse(Console.ReadLine(), out v);

            if(v1)
            {
                int bitAt3 = (v >> 3) & 1;
                int bitAt24 = (v >> 24) & 1;

                int bitAt4 = (v >> 4) & 1;
                int bitAt25 = (v >> 25) & 1;

                int bitAt5 = (v >> 5) & 1;
                int bitAt26 = (v >> 26) & 1;

                v = v & (~(1 << 24)) | (bitAt3 << 24);
                v = v & (~(1 << 3)) | (bitAt24 << 3);

                v = v & (~(1 << 25)) | (bitAt4 << 25);
                v = v & (~(1 << 4)) | (bitAt25 << 4);

                v = v & (~(1 << 26)) | (bitAt5 << 26);
                v = v & (~(1 << 5)) | (bitAt26 << 5);

                Console.WriteLine("The value after replacing the bit value at 3 with bit value at 24, bit value at 4 with bit value at 25 and bit value at 5 with bit value at 26 is = " + v);
            }
            else
            {
                Console.WriteLine("Invalid input is entered");
            }
            

            Console.ReadLine();
        }
    }
}
