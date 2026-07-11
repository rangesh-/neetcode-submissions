
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
List<int> result = new List<int>();
        foreach(var nums in nums1){
            result.Add(nums);
        }
        foreach(var nums in nums2){
            result.Add(nums);
        }
        result.Sort();

        var length = result.Count;
        if(length %2 ==0){
         return (result[length / 2] + result[(length / 2) - 1]) / 2.0;
        }
        else{
            return (double)result[length/2];
        }

    }
}
