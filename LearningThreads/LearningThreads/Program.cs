using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                Thread myThread = new Thread(new ThreadStart(Work));

                myThread.Start();

                Task.Run(() =>
                {
                    Console.WriteLine("starting task: " + Thread.CurrentThread.ManagedThreadId);

                    Thread.Sleep(3000);

                    Console.WriteLine("task complete");
                });
            }

            Console.ReadLine();
        }

        static void Work()
        {
            Console.WriteLine("starting thread: " + Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(3000);

            Console.WriteLine("work complete");
        }
    }
}
