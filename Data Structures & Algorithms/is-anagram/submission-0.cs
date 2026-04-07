public class Solution {
    public bool IsAnagram(string s, string t) {
if (s.Length != t.Length) return false;

    var charCount = new Dictionary<char, int>();

    foreach (var c in s)
    {
        if (charCount.ContainsKey(c))
        {
            charCount[c]++;
        }
        else
        {
            charCount[c] = 1;
        }
    }

    foreach (var c in t)
    {
        if (charCount.ContainsKey(c) && charCount[c] > 0)
        {
            charCount[c]--;
        }
        else
        {
            return false;
        }
    }

    return true;
    }
}
