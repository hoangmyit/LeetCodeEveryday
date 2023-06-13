using BenchmarkDotNet.Running;
using MyBenchmark.DayOne;

var summary = BenchmarkRunner.Run(typeof(ContainsDuplicateBenchmark));