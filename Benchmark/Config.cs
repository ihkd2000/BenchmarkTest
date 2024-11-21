using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmarks.Benchmark
{
      public class Config:ManualConfig
    {
        
        public Config()
        {
            AddJob(Job.Default.WithRuntime(CoreRuntime.Core80)); // .NET 8.0
            AddJob(Job.Default.WithRuntime(CoreRuntime.Core90)); // .NET 9.0
            AddLogger(ConsoleLogger.Default); // Add console logging to see progress

        }

    }
}
