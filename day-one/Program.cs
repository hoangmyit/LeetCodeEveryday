using DayOne;

int[] arr = new int[] {
    1,1,1,3,3,4,3,2,4,2
};

Console.WriteLine("HashSet");
Console.WriteLine(ContainsDuplicate.CheckingByHashSet(arr) ? "This array is a duplicated array." : "This array don't contain any duplicated item.");

Console.WriteLine("Dictionary");
Console.WriteLine(ContainsDuplicate.CheckingByDictionary(arr) ? "This array is a duplicated array." : "This array don't contain any duplicated item.");