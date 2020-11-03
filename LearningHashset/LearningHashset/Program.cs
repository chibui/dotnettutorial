using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHashset
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHash = new HashSet<String>();

            myHash.Add("Hello");
            myHash.Add("Hello");

            String[] s = new String[] { "Hello" };

            Console.WriteLine(myHash.Count()); // 1
            Console.WriteLine(myHash.Overlaps(s)); // true

            String[] s2 = new String[] { "hello" };

            Console.WriteLine(myHash.Overlaps(s2)); // false, as s2 doesn't have a capitalized h

        }
    }
}
