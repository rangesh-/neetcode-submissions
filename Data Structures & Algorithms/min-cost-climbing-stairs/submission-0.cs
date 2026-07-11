public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        if(cost.Length==1){
            return cost[0];
        }

        if(cost.Length ==2){
            return Math.Min(cost[0],cost[1]);
        }

        var dp=cost;
        for(var i=2;i<cost.Length;i++){
            dp[i] = Math.Min(cost[i-2]+dp[i] ,cost[i-1]+dp[i]);
        }

        return Math.Min(dp[cost.Length-2],dp[cost.Length-1]);
    }
}
