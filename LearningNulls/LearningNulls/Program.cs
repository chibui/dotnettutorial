using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningNulls
{
    class Program
    {
        static void Main(string[] args)
        {
            //var s = "Hello";
            //var s2 = s ?? "Default";

            //Console.WriteLine(s2); // "Hello"

            //String s = null;
            //var s2 = s ?? "Default";
            //Console.WriteLine(s2); // "Default"

            //int s = 1;
            //int s2 = s ?? "Default"; // Operator '??' cannot be applied to operands of type 'int' and 'string'
            //Console.WriteLine(s2); // 1

            //int s = 1;
            //int s2 = s ?? 2; // Operator '??' cannot be applied to operands of type 'int' and 'int'
            //Console.WriteLine(s2); // 1

            //int? s = 1;
            //int s2 = s ?? 2; // Operator '??' cannot be applied to operands of type 'int' and 'int'
            //Console.WriteLine(s2); // 1

            int? s = null;
            int s2 = s ?? 2; // Operator '??' cannot be applied to operands of type 'int' and 'int'
            Console.WriteLine(s2); // 2
        }
    }
}
