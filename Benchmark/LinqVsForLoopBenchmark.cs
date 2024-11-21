using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains;


namespace benchmarks.Benchmark
{
    public class LinqVsForLoopBenchmark
    {
        //add benchmark
        private List<int>? numbers;

        [GlobalSetup]
        public void Setup()
        {
            numbers = Enumerable.Range(1, 1000_000).ToList();
        }

        [Benchmark]
        public long LinqQuery()
        {
            return numbers!.Where(x => x % 2 == 0).Sum(x => (long)x); // Use the null-forgiving operator
        }

        [Benchmark]
        public int ForLoop()
        {
            int sum = 0;
            for (int i = 0; i < numbers!.Count; i++) // Use the null-forgiving operator
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        [Benchmark]
        public long ParallelLinqQuery()
        {
            return numbers!.AsParallel().Where(x => x % 2 == 0).Sum(x => (long)x); // Use the null-forgiving operator
        }


    }
}
