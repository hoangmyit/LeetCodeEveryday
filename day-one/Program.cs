// See https://aka.ms/new-console-template for more information
bool IsContainsDuplicate(int []arr) {
  // See https://aka.ms/new-console-template for more information
  Dictionary<int, bool> checkedTable = new Dictionary<int, bool>();
  foreach(int item in arr){
    if (checkedTable.ContainsKey(item))
    {
      return true;
    }
    checkedTable.Add(item, true);
  }
  return false;
}