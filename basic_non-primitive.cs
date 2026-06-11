using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BasicFirst
{

    public class Person
    {
        public String name;
        public int age;

        public Person(String name, int age) // paramerterized constructor
        {
            this.name = name;
            this.age = age;
        }

        public void Info()
        {
            Console.WriteLine(this.name + " " + this.age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Karim", 20);
            person1.Info();
            Console.ReadLine();
        }
    }
}
