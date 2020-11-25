using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Jesse", 20);
            Console.WriteLine($"BFORE: {p1.Name}, {p1.Age}");
            ChangePerson(p1);
            Console.WriteLine($"AFTER: {p1.Name}, {p1.Age}");


            //Another Change
            Person p2 = p1;
            p2.Name = "TEST";
            Console.WriteLine($"AFTER 2: {p1.Name}, {p1.Age}");


        }
        public static void ChangePerson(Person p1)
        {
            p1.Name = "Jeff";
            p1.Age = 50;
        }
    }
}
