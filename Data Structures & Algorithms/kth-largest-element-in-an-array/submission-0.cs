public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var minheap = new PriorityQueue<int,int>();
        foreach(var num in nums){
            minheap.Enqueue(num,num);
            if(minheap.Count>k){
                minheap.Dequeue();
            }
        }

      
        return minheap.Peek();

    }
}
