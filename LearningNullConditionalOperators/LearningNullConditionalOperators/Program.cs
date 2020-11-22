using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningNullConditional
{
    class Person
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = null; //new Person() { Name = "Tim" }; //what if this was null

            if(person != null) // manual null check.
                Console.WriteLine(person.Name);

            Console.WriteLine(person?.Name); // null conditional operator

            Person person2 = new Person(); //{ Name = "Tim" }; //what if this was null
            //Console.WriteLine(person2?.Name.Length); // expect: null reference expection

            //Console.WriteLine(person2?.Name?.Length); // nested null conditional operator.  expect: 3

            Console.WriteLine(person2?.Name ?? "not set"); // nested null conditional operator with default value.  expect: "not set"
        }
    }
}
