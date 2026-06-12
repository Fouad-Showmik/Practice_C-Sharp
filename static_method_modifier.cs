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
    public class Animal
    {
        public string name;
        public int age;
        public static int counterInstance; //static modifier

        public static void Info() // static method
        {
            Console.WriteLine("They all can walk");
        }

        public Animal(string name, int age) //parameterized constructor
        {
            this.name = name;
            this.age = age;
            counterInstance++;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Animal obj1 = new Animal("Tiger", 2);
            Animal obj2 = new Animal("Croc",1);
            Animal obj3 = new Animal("Cow",3);
            Console.WriteLine("Total: " + Animal.counterInstance);
            Animal.Info();
            
        }
    }
}
