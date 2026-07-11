public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        
        foreach (char c in s) {
            // If it's an opening bracket, push it
            if (c == '(' || c == '{' || c == '[') {
                st.Push(c);
            } 
            else {
                // If stack is empty but we have a closing bracket, it's invalid
                if (st.Count == 0) return false;
                
                char top = st.Pop(); // Pop and check in one go
                if (c == ')' && top != '(') return false;
                if (c == '}' && top != '{') return false;
                if (c == ']' && top != '[') return false;
            }
        }
        
        // Final check: stack must be empty
        return st.Count == 0;
    }
}