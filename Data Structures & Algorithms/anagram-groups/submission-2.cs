public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
{
   var dict = new Dictionary<string, List<string>>();
   foreach (var item in strs)
   {
      var temp = new int[26];
      foreach (var ch in item)
      {
          temp[ch-'a']++;
      }
      var key = string.Join(",", temp);
      if (dict.ContainsKey(key)) dict[key].Add(item);
      else
      {
         dict[key] = [item];
      }
   }
   return [.. dict.Values];

}
}
