using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningAsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading File");
            Download();
            Console.ReadLine();
        }

        static async void Download()
        {
            //await Network.Download();

            HttpClient client = new HttpClient();

            var data = await client.GetStringAsync("https://google.com");

            Console.WriteLine("Download Complete" + data);
        }

        // Mock external network library
        //class Network
        //{
        //    static public Task Download()
        //    {
        //        return Task.Run(() => Thread.Sleep(3000) );
        //    }
        //}
    }
}
