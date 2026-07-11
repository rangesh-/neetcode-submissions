public class Solution {
    public int NumDecodings(string s) {

      var length= s.Length;

      var dp = new int[length+1];

      dp[0]=1;
      if(s[0]=='0'){
        
        dp[1]=0;
      }  
      else{
        dp[1]=1;
      }

      for(int i =2;i<=length;i++){

        //singledigit 
        var singledigit= Convert.ToInt32(s.Substring(i-1,1));
        var doubledigit = Convert.ToInt32(s.Substring(i-2,2));

        if(singledigit>=1){
          dp[i]+=dp[i-1];
        }

        if(doubledigit>=10 && doubledigit<=26){
          dp[i]+=dp[i-2];
        }
      }

      return dp[length];
    }
}
