using BasicFirst.Math;
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
            var result = Calc.Addition(2, 5);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
