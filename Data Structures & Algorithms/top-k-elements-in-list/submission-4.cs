public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int,int>();

        foreach(var num in nums){
            if(dict.ContainsKey(num)){
                dict[num]+=1;
            }
            else{
                dict[num]=1;
            }
        }
       var ordered = dict.OrderByDescending(x => x.Value);

       var res = new List<int>();
       foreach( var item in ordered){
        if(res.Count<k){
            res.Add(item.Key);
        }
       }
       return res.ToArray(); 

    }
}
