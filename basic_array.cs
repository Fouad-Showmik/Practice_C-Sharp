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
            string[] car = {"Coro","Toyo"};
            car[1] = "Suv";


            int[] numic = { 1, 2 };
            Console.WriteLine(numic[0]);
            Console.WriteLine(car[1]);
            Console.ReadLine();
        }
    }
}
