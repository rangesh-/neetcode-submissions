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
    public ListNode ReverseList(ListNode head) {
       var currnode = head;
       ListNode prev = null ;

       while(currnode !=null){
        var nextnode = currnode.next;
        currnode.next=prev;
        prev=currnode;
        currnode=nextnode;
       }

       head=prev;
       return head;
    }
}
