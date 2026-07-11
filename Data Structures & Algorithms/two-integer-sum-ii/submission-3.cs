public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
       var dict = new Dictionary<int,int>();
       var res = new int[2]; 
       for (int i=0;i<numbers.Length;i++){
         if(dict.ContainsKey(numbers[i])){
            res[0]=dict[numbers[i]]+1;
            res[1]=i+1;

         }
         else{
            dict[target-numbers[i]]=i;
         }

       }

       return res;
       
    }
}
