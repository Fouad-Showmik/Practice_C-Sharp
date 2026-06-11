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

    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[5] { 1, 2, 3, 4, 5 };
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            List<int> lst = new List<int>();

            for (int i = 0; i <= 10; i++)
            {
                lst.Add(i);
            }

            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }
    }
}
