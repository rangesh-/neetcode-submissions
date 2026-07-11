public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var dict = new Dictionary<String,List<string>>();
        foreach(var str in strs){
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            var sortedstring = new String(chars);
            if(!dict.ContainsKey(sortedstring)){     
              dict[sortedstring]=new List<string>();
            }
            dict[sortedstring].Add(str);
        }

        var result = new List<List<string>>();

        foreach(var item in dict){
            var list = item.Value;
            result.Add(list);
        }
return result;

    }
}
