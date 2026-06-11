using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //Console.ReadLine();


            var firstName = "Fouad";
            var lastName = "Showmik";
            var fullName = firstName + " " + lastName;

            const float Pi = 3.14156f;

            Console.WriteLine(fullName);
            Console.WriteLine(Pi);
            Console.ReadLine();
        }
    }
}