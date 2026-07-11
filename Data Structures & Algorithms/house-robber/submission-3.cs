public class Solution {
    public int Rob(int[] nums) {
              if(nums.Length==1){
            return nums[0];
        }

        if(nums.Length ==2){
            return Math.Max(nums[0],nums[1]);
        }

        var dp=nums;
        dp[1]=Math.Max(nums[0],nums[1]);
        for(var i=2;i<nums.Length;i++){
            dp[i] = Math.Max(nums[i-2]+dp[i] ,dp[i-1]);
        }

        return dp[nums.Length-1];
    }
    
}
