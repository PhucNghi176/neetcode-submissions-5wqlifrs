public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length) return false;
        var dict = new Dictionary<char,int>();
        foreach(var item in s){
            if(dict.ContainsKey(item)) dict[item]++;
            else dict.Add(item,0);
        }
        foreach(var item in t){
            if(!dict.ContainsKey(item)) return false;
            else if (dict[item] < 0) return false;
            else dict[item]--;
        }

        return true;
    }
}
