using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BasicFirst
{

    public class Shape
    {
        public string color;
    }

    public class findTriangle : Shape
    {
        public void Info(int b, int h)
        {
            var result = ((1f/2f) * b * h);
            Console.WriteLine(color + " "+ result);
        }

        public findTriangle(string color)
        {
            this.color = color;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            findTriangle obj1 = new findTriangle("Blue");
            obj1.Info(5, 2);
        }
    }
}
