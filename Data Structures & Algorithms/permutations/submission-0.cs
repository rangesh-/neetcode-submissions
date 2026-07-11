public class Solution {
    List<List<int>> res;
    public List<List<int>> Permute(int[] nums) {
        res = new List<List<int>>();
      
        var per = new List<int>();
        var vis = new bool[nums.Length];
        backtrack(per,nums,vis);
        return res;

    }

    public void backtrack(List<int> per,int[] nums, bool [] visited){

        if(per.Count == nums.Length){
            res.Add(new List<int>(per));
            return;
        }

        for(int i=0 ; i<nums.Length;i++){
            if(!visited[i]){
             visited[i]=true;
             per.Add(nums[i]);
             backtrack(per,nums,visited);
             per.RemoveAt(per.Count-1);
             visited[i]=false;
            }
        }
    }
}
