public class Solution {
    public int FindPeakElement(int[] nums) {
        int l =0;
        int r = nums.Length-1;

        while(l<=r){
            var mid = l+(r-l)/2;
            if(mid>0 && nums[mid]<nums[mid-1]){
                r=mid-1;
            }
            else if ( mid <nums.Length-1 && nums[mid]<nums[mid+1]){
                l=mid+1;
            }
            else{return mid;
            }
            
                    }

                    return l;
    }
}