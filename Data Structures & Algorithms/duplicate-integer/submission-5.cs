public class Solution {
    public bool hasDuplicate(int[] nums) {
        var dict = new Dictionary<int,int>();

        foreach (var num in nums){
            if(dict.ContainsKey(num)){
                return true;
            }
            else{
                dict[num]=1;
            }
        }
          return false;   
                    
           
    }
}