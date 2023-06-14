using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using MyBenchmark.DayOne;

namespace DataStructureOne
{
  internal class Program
  {
    static void Main(string[] args)
    {

#if DEBUG
      BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly)
      .Run(args, new DebugInProcessConfig());
#endif
      // var containsDuplicateSummary = BenchmarkRunner.Run(typeof(ContainsDuplicateBenchmark));
      var maximumSubArraySummary = BenchmarkRunner.Run(typeof(MaximumSubArrayBenchmark));
    }
  }
}

