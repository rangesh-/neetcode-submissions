public class Solution {  
    public List<string> GenerateParenthesis(int n) {
      var res="";
      var result = new List<string>();
      backtrack(0,0,result,n,res);
      return result;
    }

    public void backtrack(int open,int closed ,List<string> res, int n,string r){
        if(open==closed && open==n){
            res.Add(r);
            return;
        }

        if(open<n){
            backtrack(open+1,closed,res,n,r+"(");
        }

        if(closed<open){
            backtrack(open,closed+1,res,n,r+")");
        }
    }
}
