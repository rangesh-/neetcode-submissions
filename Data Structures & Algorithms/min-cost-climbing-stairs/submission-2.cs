public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        
        if(cost.Length==1){
            return cost[0];
        }

        if(cost.Length==2){
            return Math.Min(cost[0],cost[1]);
        }

        var dp = new int[cost.Length+1];
        dp[0]=0;
        dp[1]=0;
  
        for(int i=2;i<=cost.Length;i++){
            dp[i]=Math.Min(dp[i-1]+cost[i-1],dp[i-2]+cost[i-2]);

        }

        return dp[cost.Length];
    }
}
