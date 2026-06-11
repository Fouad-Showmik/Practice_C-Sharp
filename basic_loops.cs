using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            //for loop

            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

            //while loop


            int x = 0;
            while (x <= 20)
            {
                Console.WriteLine(x);
                x++; x += 1;
            }

            //do while

            var y = 20;
            do
            {
                Console.WriteLine(y);
                y++;
            } while (y <= 50);

            //foreach

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            foreach (var number in numbers) {
                Console.WriteLine(number);
            }
        }
    }
}
