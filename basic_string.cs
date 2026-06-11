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
            string firstName = "Royal";
            string lastName = "Enfield";

            var result = string.Concat(firstName, lastName);

            Console.WriteLine(result);
            Console.WriteLine(result[1]);
            Console.WriteLine(result.IndexOf("o"));
            Console.ReadLine();
        }
    }
}
