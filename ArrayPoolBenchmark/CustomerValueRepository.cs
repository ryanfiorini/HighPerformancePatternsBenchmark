using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighPerformancePatternsBenchmark
{
    [MemoryDiagnoser]
    public class CustomerValueRepository
    {
        List<CustomerValue> customers = new List<CustomerValue>();

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
