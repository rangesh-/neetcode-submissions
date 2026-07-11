public class Solution {
    public int CoinChange(int[] coins, int amount) {
       if(amount<1){
        return 0;
       }
       var dp=new int[amount+1];
       dp[0]=0;
       for(int i=1;i<=amount;i++){
        dp[i]=int.MaxValue;
        foreach(var coin in coins){
            if(coin<=i && dp[i-coin]!=int.MaxValue){
              dp[i]=Math.Min(dp[i-coin]+1,dp[i]); 
            }
        }
       }

       if(dp[amount]==int.MaxValue){
        return -1;
       }
       return dp[amount];
    }
}
