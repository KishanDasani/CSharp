using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical5
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void DecimalToBinary()
        {
            int decimalNumber = 7;
            int i = 0;
            int[] binaryNumer = new int[40];

            while (decimalNumber != 0) { 
            
            binaryNumer[i] = decimalNumber % 2;
                i++;

                decimalNumber /= 2;
            }

            for(int j=i-1;j>=0;j--)
            {
                Console.Write(binaryNumer[j]);
            }
        }
    }
}