namespace DataStructureOne.FirstDay;

public class MaximumSubArray
{
  public MaximumSubArray()
  {

  }
  // [-2,1,-3,4,-1,2,1,-5,4]
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
}
