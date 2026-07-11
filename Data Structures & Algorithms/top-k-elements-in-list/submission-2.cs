public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new SortedDictionary<int,int>();
        foreach(var items in nums){
            if(dict.ContainsKey(items)){
                dict[items]=dict[items]+1;
            }
            else{
                dict[items]=1;
            }
        }
        var res=new List<int>();
     foreach (var item in dict.OrderByDescending(key => key.Value))
{
if(res.Count-1<k-1){
res.Add(item.Key);
}    

    }

    return res.ToArray();

}
}
