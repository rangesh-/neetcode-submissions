public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        const int INF = 2147483647;
        // Define the possible directions for BFS: Up, Down, Left, Right
        int[][] Dirs = new int[][] {
            new int[] {1, 0},
            new int[] {-1, 0},
            new int[] {0, 1},
            new int[] {0, -1} };

        var m = grid.Length;
        if (m == 0) return;
        var n = grid[0].Length;
        Queue<int[]> q = new Queue<int[]>();
        for(int r=0;r<m;r++){
            for(int c=0;c<n;c++){
                if(grid[r][c]==0){
                    q.Enqueue(new int[]{r,c});
                }
            }
        }
        while(q.Count>0){
            var element = q.Dequeue();
            var i=element[0];
            var j= element[1];
            foreach (var dir in Dirs){
                var nr = i+dir[0];
                var nc= j+dir[1];
                if(nr >=0 && nc>=0 && nr<m && nc<n && grid[nr][nc]==INF){
                grid[nr][nc]=grid[i][j]+1;
                q.Enqueue(new int[]{nr,nc});
                }
            }
        } 
    }
}