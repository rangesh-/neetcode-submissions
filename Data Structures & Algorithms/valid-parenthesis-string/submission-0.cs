public class Solution {
    public bool CheckValidString(string s) {
        var openstack = new Stack<int>();
        var starstack = new Stack<int>();
     for(int i=0;i<s.Length;i++){
        if(s[i]=='('){
            openstack.Push(i);
        }
        else if(s[i]=='*'){
            starstack.Push(i);
        }
        else{
           if(openstack.Count>0){
            openstack.Pop();
           }
           else if(starstack.Count>0){
            starstack.Pop();
           }
           else{
            return false;
           }
        }
     }
       
    while(openstack.Count>0 && starstack.Count>0){
        if(openstack.Peek()<starstack.Peek()){
            openstack.Pop();
            starstack.Pop();
        }
        else{
            return false;
        }
    }

    if(openstack.Count==0){
        return true;
    }
 return false;
    }
}
