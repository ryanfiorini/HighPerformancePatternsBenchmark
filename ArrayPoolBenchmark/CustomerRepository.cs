using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighPerformancePatternsBenchmark
{
    [MemoryDiagnoser]
    public class CustomerRepository
    {
        List<Customer> customers = new List<Customer>();

        [Benchmark]
        public void UpdateScoring()
        {
            foreach (var item in customers)
            {
                item.UpdateScoring();
            }
        }
    }
}
