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
            var UserSeason = Season.Winter;

            switch (UserSeason)
            {
                case Season.Summer:
                    Console.WriteLine("Hot weather");
                    break;
                case Season.Winter:
                    Console.WriteLine("Cold Weather");
                    break;
                case Season.Rainy:
                    Console.WriteLine("Bad season");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Good Season");
                    break;
                default:
                    break;
            }

        }
    }
}
