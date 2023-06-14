using BenchmarkDotNet.Attributes;
using DayOne.FirstDay;

namespace MyBenchmark.DayOne
{
  [MemoryDiagnoser]
  public class ContainsDuplicateBenchmark
  {
    private ContainsDuplicate _containDuplicate;
    private int[] arr;
    [GlobalSetup]
    public void GlobalSetup()
    {
      _containDuplicate = new ContainsDuplicate();
      arr = new int[] {
        1,5,12,23,34,42,36,2,4,2
    };
    }

    [Benchmark]
    public void ContainsDuplicateDictionaryBenchmark()
    {
      _containDuplicate.CheckingByDictionary(arr);
    }
    [Benchmark]
    public void ContainsDuplicateHashBenchmark()
    {
      _containDuplicate.CheckingByHashSet(arr);
    }
  }
}
