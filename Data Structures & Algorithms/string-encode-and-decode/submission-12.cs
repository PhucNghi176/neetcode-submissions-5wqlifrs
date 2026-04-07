public class Solution {

public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach(var s in strs){
            int count = s.Length;
            sb.Append($"{count}#{s}");
        }
        return sb.ToString();

    }

    public List<string> Decode(string s) {
        var list = new List<string>();
        int i =0;
        while(i<s.Length){
            int j =i;
            while(s[j]!='#'){
                j++;
            }
            int length =int.Parse(s.Substring(i,j-i));
            i=j+1;
            j=i+length;
            list.Add(s.Substring(i,length));
            i=j;
        }

        return list;
   }
}

/*
    public List<string> Decode(string s) {
        var list = new List<string>();
        for(int i=0;i<s.Length;i++){
            int j =0;
            if(s[i]=='#'){
                list.Add(s.SubString(i+1,j);)
            }
            j=i-1;
        }

        return list;
   }
*/
