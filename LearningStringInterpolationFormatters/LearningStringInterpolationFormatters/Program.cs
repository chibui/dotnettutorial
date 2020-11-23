using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningStringInterpolationFormatters
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new { x = 1.1234, y = 2.1254 };

            Console.WriteLine($"x {point.x} y {point.y:N1}"); // limit decimals to 1 expect x 1.1234 y 2.1
            Console.WriteLine($"x {point.x} y {point.y:N2}"); // limit decimals to 2 expect x 1.1234 y 2.13
            Console.WriteLine($"x {point.x} y {point.y, 10:N2}"); // prepend with 10 spaces,  limit decimals to 2 expect x 1.1234 y       2.13
        }
    }
}
