namespace Day_One
{
    public static class ContainsDuplicate
    {
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
    }
}
