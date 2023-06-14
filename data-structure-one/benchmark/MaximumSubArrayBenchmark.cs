using BenchmarkDotNet.Attributes;
using DataStructureOne.FirstDay;

namespace MyBenchmark.FirstDay
{
  [MemoryDiagnoser]
  public class MaximumSubArrayBenchmark
  {
    private MaximumSubArray _maximumSubArray;
    private int[] arr;
    [GlobalSetup]
    public void GlobalSetup()
    {
      _maximumSubArray = new MaximumSubArray();
      arr = new int[] {
        1,5,12,23,34,42,36,2,4,2
    };
    }

    [Benchmark]
    public void ContainsDuplicateForLoopBenchmark()
    {
      _maximumSubArray.CalculateMaxSubArray(arr);
    }
  }
}
