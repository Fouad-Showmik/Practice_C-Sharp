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

            if(number % 2 == 0)
            {
                Console.WriteLine("Even");
            }else
            {
                Console.WriteLine("Odd");
            }

        }
    }
}


///---------------------else if




namespace BasicFirst
{



    class Program
    {
        static void Main(string[] args)
        {
            //var number = 10;
            var number = int.Parse(Console.ReadLine());

            if(number <= 20)
            {
                Console.WriteLine("Smaller");
            }else if(number > 20 && number <= 50)
            {
                Console.WriteLine("Medium");
            }
            else
            {
                Console.WriteLine("Bigger");
            }

        }
    }
}

