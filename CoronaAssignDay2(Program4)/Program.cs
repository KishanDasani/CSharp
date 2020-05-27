using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaAssignDay2_Program4_
{
    class Program
    {
        static void Main(string[] args)
        {

            /*bool isMale,valid;

            string gender = Console.ReadLine(); 

            if (Regex.IsMatch(gender, "^male$|^female$") ? valid = true : valid = false) ;

            if(valid)
            {
                if (gender.Equals("male") ? isMale = true : isMale = false) ;
                Console.WriteLine(isMale ? "You're a Male" : "You're a Female");
            }

            Console.ReadLine();*/

            string gender = "Male";

            bool isMale = gender == "Male" ? true : false;

            Console.WriteLine(isMale ? "You're a Male" : "You're a Female");

            Console.ReadLine();
        }
    }
}
