using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList List = new ArrayList();

            List.Add("some string");

            String s = (String)List[0];

            Console.WriteLine(s.Length);
        }
    }
}
