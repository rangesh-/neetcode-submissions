public class Solution {
    public string LongestPalindrome(string s) {
        var reslen=0;
        var startpointer=0;
        for(int i=0;i<s.Length;i++){

            var left =i; 
            var right =i ;

            while(left>=0 && right<s.Length && s[left] == s[right]){
                if(right-left +1 >reslen){
                    startpointer=left;
                    reslen=right-left +1;
                }
                left--;
                right++;
            }

          left=i;
          right=i+1;
         while(left>=0 && right<s.Length && s[left] == s[right]){
                if(right-left +1 >reslen){
                    startpointer=left;
                    reslen=right-left +1;
                }
                left--;
                right++;
            }
    }
    

    return s.Substring(startpointer,reslen);
}
}
