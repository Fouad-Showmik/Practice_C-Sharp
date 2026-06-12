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
    class Income
    {
        private int _income = 40000;

        public int accessIncome
        {
            get { return _income; }

            set
            {
                if (value <= 0)
                {
                    _income = 0;
                }
                else if (value > 50000)
                {
                    _income = 50000;
                }
                else
                {
                    _income = value;
                }

            }
        }

        public int Debit(int money)
        {
            return _income = _income - money;
        }

        public void Info()
        {
            Console.WriteLine(_income);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Income obj1 = new Income();
            obj1.accessIncome = 20000;
            obj1.Debit(10000);
            Console.WriteLine(obj1.accessIncome);
        }
    }
}
