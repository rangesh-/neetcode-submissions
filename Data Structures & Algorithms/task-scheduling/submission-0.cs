public class Solution {
    public int LeastInterval(char[] tasks, int n) {
       var count = new int[26];
       foreach(var task in tasks){
        count[task-'A']++;
       }

       var maxheap = new PriorityQueue<int,int>();

       for(int i =0;i<26;i++){
        if(count[i]>0){
            maxheap.Enqueue(count[i],-count[i]);
        }
       }

       var que = new Queue<int[]>();
       var time=0;

       while(que.Count>0 || maxheap.Count>0){
        if(que.Count>0 && time==que.Peek()[1] ){
           var temp = que.Dequeue();
           maxheap.Enqueue(temp[0],-temp[0]);
        }

        if(maxheap.Count>0){
            var s = maxheap.Dequeue() -1;
            if(s>0){
                que.Enqueue(new int[] {s,time+n+1});
            }
        }
       time++;
       } 

     return time; 
    }
}
