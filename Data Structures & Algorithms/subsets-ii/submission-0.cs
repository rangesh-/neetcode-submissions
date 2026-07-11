public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        List<List<int>> result = new List<List<int>>();
        List<int> path = new List<int>();
        backtrack(0,result,path,nums);
        return result;
    }

    public void backtrack(int index,List<List<int>> res, List<int>path,int[] nums){
       
            res.Add(new List<int>(path));
       
        for(int i =index ;i <nums.Length;i++){
         if(i >index && nums[i]==nums[i-1]){
            continue;
         }
         path.Add(nums[i]);
         backtrack(i+1,res,path,nums);
         path.RemoveAt(path.Count-1);   
        }

    }
}
