public class Solution {
    public int FindDuplicate(int[] nums) {

     var hashset = new HashSet<int>();
     foreach(var num in nums){
        if(hashset.Contains(num)){
            return num;
        }
        else{
            hashset.Add(num);
        }
     }
        return -1;
    }
}
