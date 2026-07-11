public class Solution {
    public List<List<string>> Partition(string s) {
      var res= new List<String>();
      var result = new List<List<string>>();
      dfs(0,s,res,result);  
      return result;
    }

   
public void dfs(int start,string s,List<string> res, List<List<string>> result){
    if(start >= s.Length){
         result.Add(new List<string>(res));
        return;
    }

    for(var end = start; end<s.Length;end++){
        if(ispal(s,start,end)){
            res.Add(s.Substring(start,end-start+1));
            dfs(end+1,s,res,result);
            res.RemoveAt(res.Count-1);
        }

    }
}

   private bool ispal(string s, int l, int r) {
        while (l < r) {
            if (s[l] != s[r]) {
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}
