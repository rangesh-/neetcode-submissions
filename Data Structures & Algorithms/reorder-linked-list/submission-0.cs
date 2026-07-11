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
    public void ReorderList(ListNode head) {
        
        //find the middle element 

     var p1 = head;
     var p2 =head.next;
     while(p2!=null && p2.next!=null)
          {
            p1=p1.next;
            p2=p2.next.next;
          }

       var currentnode=p1.next;
       p1.next =null;
       ListNode prev=null;

       while(currentnode!=null){
        var nextnode= currentnode.next;
        currentnode.next=prev;
        prev=currentnode;
        currentnode=nextnode;
       }

       var first = head;
       var second = prev;

       while(second !=null){
        var temp1 = first.next;
        var temp2 = second.next;

        first.next = second;
        second.next=temp1;

        first = temp1;
        second = temp2;
       }   
    }
}
