public class Solution {
    public int CountSubstrings(string s) {
        
        var res =0 ;

        for(int i=0;i<s.Length;i++){
            var left=i;
            var right =i; 

            while(left>=0 && right<s.Length && s[left] ==s[right]){
                res++;
                left--;
                right++;
            }

            left=i;
            right=i+1;

            while(left>=0 && right<s.Length && s[left] ==s[right]){
                res++;
                left--;
                right++;
            }
        }

        return res;
    }
}
