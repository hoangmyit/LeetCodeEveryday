# Day one

## Contains Duplicate

- using Hash set

```csharp
  public static bool CheckingByHashSet(int[] nums)
  {
      HashSet<int> checkedTable = new HashSet<int>();
      for (int i = 0; i < nums.Length; i++)
      {
          if (!checkedTable.Add(nums[i]))
          {
              return true;
          }
      }
      return false;
  }
        
```

- using Dictionary

```csharp
  public static bool CheckingByDictionary(int[] nums)
  {
      Dictionary<int, bool> checkedTable = new Dictionary<int, bool>();
      foreach (int item in nums)
      {
          if (checkedTable.ContainsKey(item))
          {
              return true;
          }
          checkedTable.Add(item, true);
      }
      return false;
  }
```

## Maximum sub array

```csharp
   public int CalculateMaxSubArray(int[] nums)
  {
    int maxSum, currentSum = 0;
    maxSum = nums[0];
    for (int i = 0; i < nums.Length; i++)
    {
      currentSum += nums[i];
      if (maxSum < currentSum)
      {
        maxSum = currentSum;
      }
      if (currentSum < 0)
      {
        currentSum = 0;
      }
    }
    return maxSum;
  }
```
