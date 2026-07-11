public class Solution {
    public int Jump(int[] nums) {
      var reach = 0;
      var currentedge=0;
      var jump=0;
      for(int i=0;i<nums.Length-1;i++){
          
        reach = Math.Max(reach,i+nums[i]);
        if(i==currentedge){
            jump++;
            currentedge=reach;
        }         
      }

      return jump;  
    }
}
