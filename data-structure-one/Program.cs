using BenchmarkDotNet.Running;
using MyBenchmark.DayOne;

#if DEBUG
Console.WriteLine("Debug mode");
#else
var containsDuplicateSummary = BenchmarkRunner.Run(typeof(ContainsDuplicateBenchmark));
var maximumSubArraySummary = BenchmarkRunner.Run(typeof(MaximumSubArrayBenchmark));
#endif

