using System;
using RestSharp;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LB_Zaj4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var stopwatch = new Stopwatch();
         
            var google = new RestClient("http://google.pl");
            var ath = new RestClient("http://ath.bielsko.pl");
            var wiki = new RestClient("http://pl.wikipedia.org");
            var gov = new RestClient("http://gov.pl");
            var request = new RestRequest("/");//http://google.pl
            var tasks = new List<Task>();
            stopwatch.Start();
            tasks.Add(google.ExecuteAsync(new RestRequest("/"), Method.GET));
            Console.WriteLine();
            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Stop();

        }
    }
}
