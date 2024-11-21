// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using benchmarks.Benchmark;
using Microsoft.Diagnostics.Tracing.Parsers.Kernel;
using System.Reflection.Emit;


BenchmarkRunner.Run<LinqVsForLoopBenchmark>(new Config());

