/*
* To Run In Command Line 
* dotnet run -p BenchmarkSumOptimizations.csproj -c Release
* 
*/

using BenchmarkDotNet.Attributes;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPoolBenchmark
{
    [MemoryDiagnoser]
    public class ArrayPoolbenchmark
    {
        [Benchmark]
        public DataClass[] VersionObjectArray()
        {
            int itemsCount = 1000;

            DataClass[] data = new DataClass[itemsCount];

            for (int i = 0; i < itemsCount; i++)
            {
                data[i] = new DataClass();
                data[i].Age = 25;
                data[i].Gender = "male";
            }

            return data;
        }

        [Benchmark]
        public DataClass[] VersionClassArrayPool()
        {
            int itemsCount = 1000;

            DataClass[] data = ArrayPool<DataClass>.Shared.Rent(itemsCount);

            for (int i = 0; i < itemsCount; i++)
            {
                data[i] = new DataClass();
                data[i].Age = 25;
                data[i].Gender = "male";
            }

            return data;
            ArrayPool<DataClass>.Shared.Return(data);
        }
    }
}
