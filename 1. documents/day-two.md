# Day two

## Two Sum

- Simple

```csharp
 public int[] CalculateTwoSum(int[] nums, int target)
  {
    int[] result = new int[2];
    IDictionary<int, int> dictionary = new Dictionary<int, int>();
    int temp;
    for (int i = 0; i < nums.Length; i++)
    {
      if (dictionary.TryGetValue(target - nums[i], out temp))
      {
        result[0] = temp;
        result[1] = i;
        break;
      }
      dictionary.TryAdd(nums[i], i);
    }
    return result;
  }
```
