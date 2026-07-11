public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
     
     var temp = new Dictionary<string,List<string>>();
     foreach( var s in strs){
        var sortedstring =new string (s.OrderBy(c => c).ToArray());
        if(temp.ContainsKey(sortedstring)){
          var t=temp[sortedstring];
          t.Add(s);
          temp[sortedstring]=t;
        }
        else{
             var s1= new List<string>();
            s1.Add(s);
            temp[sortedstring]=s1;
        }
     }
 return temp.Values.ToList();
   
    }
}
