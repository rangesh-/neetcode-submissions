/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var result = new ListNode(0);
        var ptr = result;

        var carry=0; 
        while(l1!=null || l2!=null){
          
           var sum = 0+carry;

           if(l1!=null){
            sum=sum+l1.val;
            l1=l1.next;
           }
           if(l2!=null){
            sum=sum+l2.val;
            l2=l2.next;
           }

       
           carry= sum/10;
           sum = sum%10;
           ptr.next = new ListNode(sum);
           ptr=ptr.next;
        }
        if(carry!=0){
           ptr.next = new ListNode(carry);
        }

        return result.next;

    }
}
