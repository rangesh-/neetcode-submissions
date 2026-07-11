public class Solution {
    public bool CanJump(int[] nums) {

    var maxreach = 0;
     for(int i =0;i<nums.Length;i++){
        if(i>maxreach){
            return false;
        }
        maxreach=Math.Max(maxreach,i+nums[i]);
        if(maxreach>=nums.Length-1){
            return true;
        }

     }

     return false; 

    }
}
