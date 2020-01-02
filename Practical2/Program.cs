using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, country;
            int flag = 0;

            Console.WriteLine("Enter your good name");
            username = Console.ReadLine();

            Console.WriteLine("\nWhere are you from?");
            country = Console.ReadLine();

            if (Regex.IsMatch(username , @"^[a-zA-Z]+$") && Regex.IsMatch(country , @"^[a-zA-z]+$" ))
                flag = 0;
            else
                flag = 1;

            if (flag == 0)
                Console.WriteLine("\nWelcome " + username + " from country " + country);
            else
                Console.WriteLine("\nPlease enter valid details.. your name and country inputs must contain only characters");

            Console.ReadKey();
        }
    }
}
