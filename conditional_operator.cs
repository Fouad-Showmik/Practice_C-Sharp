using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BasicFirst
{



    class Program
    {
        static void Main(string[] args)
        {
            //var number = 10;
            var number = int.Parse(Console.ReadLine());

            var result = (number % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(result);

        }
    }
}
