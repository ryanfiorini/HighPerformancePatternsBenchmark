using BenchmarkDotNet.Running;
using HighPerformancePatternsBenchmark;
using System;

namespace ArrayPoolBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START");

            //var summary = BenchmarkRunner.Run<ArrayPoolbenchmark>();
            var summary = BenchmarkRunner.Run<CustomerRepository>();
            //var summary = BenchmarkRunner.Run<CustomerValueRepository>();

            Console.WriteLine("FINISH");
        }
    }
}
