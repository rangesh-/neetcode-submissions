public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {
        
        var maxlen=0;
       var  set = new  HashSet<string>(wordDict); 
        foreach(var words in wordDict){
            maxlen=Math.Max(maxlen,words.Length);
        }
        var dp = new bool[s.Length+1];
        dp[0]=true;
        for(int i=1;i<=s.Length;i++){
            Console.WriteLine("i"+i);
            for(int j=1;j<=maxlen && i-j>=0;j++){
                 Console.WriteLine("j"+j);
             var startindex = i-j;
             Console.WriteLine(s.Substring(startindex,j));
             if(dp[startindex] && set.Contains(s.Substring(startindex,j))){
                dp[i]=true;
                break;
             }
            }
        }

        return dp[s.Length];
    }
}
