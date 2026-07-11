public class Solution {
    public int Rob(int[] nums) {
        
      if(nums.Length ==1){
        return nums[0];
      }

      if(nums.Length ==2){
        return Math.Max(nums[0],nums[1]);
      }
int n = nums.Length;
       int robFirstRange = helper(nums, 0, n - 2); // Skip the last house
        int robLastRange  = helper(nums, 1, n - 1); // Skip the first house

        // 3. Return the best result
        return Math.Max(robFirstRange, robLastRange);

    }
    private int helper(int[]nums , int start ,int end){
      int rangeSize = end - start + 1;
      var dp = new int[rangeSize];  
     dp[0]=nums[start];
     dp[1]=Math.Max(nums[start],nums[start+1]);

     for(int i =2;i<rangeSize;i++){
      dp[i]=Math.Max(dp[i-2]+nums[start+i], dp[i-1]);
     }

    return dp[rangeSize - 1];

    }
     


    
}
