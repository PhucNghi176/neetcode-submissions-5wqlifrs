public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(var s in strs){
            var count = s.Length.ToString();
            sb.Append($"{count}#{s}");
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        int i=0;
        while(i<s.Length){
            int j=i;
            while(s[j]!='#')++j;
            int.TryParse(s.Substring(i,j++-i) ,out var len);
            result.Add(s.Substring(j,len));
            i=j+len;
        }
        return result;
   }
}
