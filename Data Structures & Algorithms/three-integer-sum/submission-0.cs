public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
  var result = new List<List<int>>();
          var seen = new HashSet<string>(); 


      for(int i=0;i<nums.Length;i++){
  
        for(int j=i+1;j<nums.Length;j++){
         var dict = new Dictionary<int,int>();
        var target = -(nums[i]+nums[j]);
     
        for(int k= j+1;k<nums.Length;k++){
         if(nums[k] ==target){
          var res = new List<int>{ nums[i],nums[j],nums[k]};
          res.Sort();
          var key = res[0]+","+res[1]+","+res[2];
          if(!seen.Contains(key)){
            seen.Add(key);
            result.Add(res);
          }
         }
         
         
        }

        }
      }

    
      return result;

    }
}
