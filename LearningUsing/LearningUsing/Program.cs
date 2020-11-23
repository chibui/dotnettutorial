using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUsing
{
    class MyResource : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disposing our resource");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (var resource = new MyResource())
            {
                Console.WriteLine("Using my resource");
            }
            Console.WriteLine("Finished");
        }
    }

    // expect
    // Using my resourc
    // Disposing our resource // even though dispose is not explicitly called, it is called by the using statement.
    // Finished
}
