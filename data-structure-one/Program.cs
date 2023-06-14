using BenchmarkDotNet.Running;
using MyBenchmark.DayOne;

// var summary = BenchmarkRunner.Run(typeof(ContainsDuplicateBenchmark));
var summary = BenchmarkRunner.Run(typeof(MaximumSubArrayBenchmark));
