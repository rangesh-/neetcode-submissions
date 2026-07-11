public class Solution {
    public int LengthOfLIS(int[] nums) {
        var dp = new int[nums.Length];
    

    for(int i=1;i<nums.Length;i++){
        for(int j=0;j<i;j++){
            if(nums[i]>nums[j]){
                if(dp[j]+1 > dp[i]){
                    dp[i]=dp[j]+1;
                }
            }
        }
    }

    var maxindex=0;
    for(int i=0;i<dp.Length;i++){
        if(dp[i]>dp[maxindex]){
            maxindex=i;
        }
    }

    return dp[maxindex]+1;

    }
}
