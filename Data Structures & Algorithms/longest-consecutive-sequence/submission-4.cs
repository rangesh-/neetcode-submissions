public class Solution {
    public int LongestConsecutive(int[] nums) {
     if (nums == null || nums.Length == 0) return 0;
        Array.Sort(nums);
        var counter=0;
        var result=0;

        var prev = nums[0];
     
        for(int i=1;i<nums.Length;i++){

            if(nums[i] == prev){
                continue;
            }
            
            if( nums[i] == prev+1 ){
                
                counter++;
                prev=nums[i];
            
            } 
            else{
              if(counter>result){
                result=counter;
              
              }
                counter=0;
                  prev=nums[i];
            }
           

         
        }

        return Math.Max(result+1, counter+1);

    }
}
