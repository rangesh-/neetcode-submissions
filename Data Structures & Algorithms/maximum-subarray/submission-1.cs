public class Solution {
    public int MaxSubArray(int[] nums) {
        var subarraysum =nums[0];
        var cursum =nums[0];

        for(int i=1;i<nums.Length;i++){
            // If its all positive continue with subarray  
            // if subarray is negative but current is positive 
           cursum = Math.Max(nums[i], cursum + nums[i]);

           //if subarray is greater ,but current is negative 
           //
            subarraysum = Math.Max(subarraysum, cursum);
        }

        return subarraysum;

    }
}
