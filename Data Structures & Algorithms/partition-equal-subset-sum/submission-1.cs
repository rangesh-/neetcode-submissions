public class Solution {
    public bool CanPartition(int[] nums) {
        
        var totalsum =0;
        foreach(var num in nums){
            totalsum+=num;
        }

        if(totalsum%2!=0){
            return false;
        }

        var target = totalsum/2;

        var dp = new bool[target+1];
        dp[0]=true;
        foreach( var num in nums){
            for(int j=target ; j>=num ;j--){
                
               if(dp[j-num]){
                dp[j]=true;
               }
            }
        }

        return dp[target];




    }
}
