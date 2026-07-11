public class Solution {
    public List<int> PartitionLabels(string s) {
        var dict = new Dictionary<char,int>();

        for(int i=0;i<s.Length;i++){
            dict[s[i]]=i;
        }

        int size=0;
        int end=0;
        var res = new List<int>();
        for(int i=0;i<s.Length;i++){
         size++;
         end=Math.Max(end,dict[s[i]]);
         if(i==end){
             res.Add(size);
            size=0;
           
         } 
 

        }
        return res;


    }
}
