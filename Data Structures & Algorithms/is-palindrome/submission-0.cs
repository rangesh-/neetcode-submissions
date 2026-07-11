public class Solution {
    public bool IsPalindrome(string s) {
       string result = String.Concat(s.Where(Char.IsLetterOrDigit));
       s=result;
        var i=0;
        var j = s.Length-1;
        while(i<j){
            if(Char.ToLower(s[i])==Char.ToLower(s[j])){
                i++;
                j--;
            }
            else{
                return false;
            }
        }
        return true;
    }
}
