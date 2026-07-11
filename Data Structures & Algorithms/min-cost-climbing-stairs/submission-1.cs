public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var dp =cost;

          if(cost.Length ==1){
             return cost[0];  
          }
          
          if(cost.Length ==2){
             return Math.Min(cost[0],cost[1]);  
          }
        for(var i =2;i<cost.Length;i++){

            dp[i]= Math.Min(dp[i-1]+cost[i] , dp[i-2]+cost[i]);

        }

        return Math.Min(dp[cost.Length-1], dp[cost.Length-2]);
    }
}
