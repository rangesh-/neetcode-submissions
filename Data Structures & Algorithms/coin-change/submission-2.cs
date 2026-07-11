public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if(amount==0){
            return 0;
        }
        var dp = new int[amount+1];
        Array.Fill(dp, amount+1);
        dp[0]=0;  
        foreach(var coin in coins){
            for(var i=coin;i<=amount;i++){

                if(coin<=amount){
                dp[i]=Math.Min(dp[i],1+dp[i-coin]);
                }

            }
        }
       if(dp[amount] <=amount){
        return dp[amount];
       }
       return -1;

    }
}
